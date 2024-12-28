import 'package:flutter/material.dart';
import 'package:science_based_meals/screens/main_navigation_screen.dart';
import 'dart:async';
import 'dart:developer' as developer;
import '../services/auth_service.dart';
import '../widgets/username_modal.dart';
import 'home_screen.dart';

class SignupScreen extends StatefulWidget {
  const SignupScreen({super.key});

  @override
  State<SignupScreen> createState() => _SignupScreenState();
}

class _SignupScreenState extends State<SignupScreen> {
  final _formKey = GlobalKey<FormState>();
  final _emailController = TextEditingController();
  final _passwordController = TextEditingController();
  final _confirmPasswordController = TextEditingController();
  final _authService = AuthService();
  Timer? _debounceTimer;
  bool _isLoading = false;
  bool _isCheckingEmail = false;
  String? _emailError;

  @override
  void dispose() {
    _emailController.dispose();
    _passwordController.dispose();
    _confirmPasswordController.dispose();
    _debounceTimer?.cancel();
    super.dispose();
  }

  bool _isValidEmailFormat(String email) {
    // Basic email format validation
    final emailRegex =
        RegExp(r'^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$');
    return emailRegex.hasMatch(email);
  }

  Future<bool> _validateEmail(String email) async {
    if (email.isEmpty) {
      setState(() => _emailError = 'Please enter your email');
      return false;
    }
    if (!_isValidEmailFormat(email)) {
      setState(() => _emailError = 'Please enter a valid email');
      return false;
    }

    setState(() {
      _isCheckingEmail = true;
      _emailError = null;
    });

    try {
      final isAvailable = await _authService.isEmailAvailable(email);
      if (!mounted) return false;

      setState(() {
        _isCheckingEmail = false;
        _emailError = isAvailable ? null : 'This email is already registered';
      });

      return isAvailable;
    } catch (e) {
      if (!mounted) return false;
      setState(() {
        _isCheckingEmail = false;
        _emailError = 'Unable to verify email availability';
      });
      return false;
    }
  }

  void _onEmailChanged(String value) {
    // Cancel any previous timer
    _debounceTimer?.cancel();

    // Clear previous error state
    setState(() {
      _emailError = null;
      _isCheckingEmail = false;
    });

    // Only check availability if email format is valid
    if (_isValidEmailFormat(value)) {
      // Start a new timer
      _debounceTimer = Timer(const Duration(milliseconds: 800), () {
        if (mounted && value == _emailController.text) {
          _validateEmail(value);
        }
      });
    }
  }

  Future<void> _signup() async {
    if (!_formKey.currentState!.validate()) return;

    // Cancel any pending validation
    _debounceTimer?.cancel();

    // Validate email availability again before proceeding
    final isEmailValid = await _validateEmail(_emailController.text);
    if (!isEmailValid) return;

    setState(() => _isLoading = true);
    try {
      if (!mounted) return;
      final username = await showDialog<String>(
        context: context,
        barrierDismissible: false,
        builder: (context) => const UsernameModal(),
      );

      if (username == null) {
        if (!mounted) return;
        setState(() => _isLoading = false);
        return;
      }

      await _authService.register(
        _emailController.text,
        _passwordController.text,
        username,
      );

      if (!mounted) return;
      Navigator.of(context).pushAndRemoveUntil(
        MaterialPageRoute(
          builder: (_) =>
              MainNavigationScreen(key: MainNavigationScreen.mainNavKey),
        ),
        (route) => false,
      );
    } catch (e, stackTrace) {
      developer.log(
        'Registration error',
        error: e,
        stackTrace: stackTrace,
        name: 'SignupScreen',
      );
      if (!mounted) return;
      ScaffoldMessenger.of(context).showSnackBar(
        const SnackBar(
          content: Text('Failed to create account. Please try again later.'),
        ),
      );
    } finally {
      if (mounted) {
        setState(() => _isLoading = false);
      }
    }
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        leading: IconButton(
          icon: const Icon(Icons.arrow_back),
          onPressed: () => Navigator.of(context).pop(),
        ),
      ),
      body: SafeArea(
        child: Center(
          child: SingleChildScrollView(
            padding: const EdgeInsets.all(24.0),
            child: Form(
              key: _formKey,
              child: Column(
                mainAxisAlignment: MainAxisAlignment.center,
                crossAxisAlignment: CrossAxisAlignment.stretch,
                children: [
                  const Text(
                    'Science-Based Meals',
                    style: TextStyle(
                      fontSize: 24,
                      fontWeight: FontWeight.bold,
                    ),
                    textAlign: TextAlign.center,
                  ),
                  const SizedBox(height: 48),
                  const Text(
                    'Create your account',
                    style: TextStyle(
                      fontSize: 20,
                      fontWeight: FontWeight.w500,
                    ),
                    textAlign: TextAlign.center,
                  ),
                  const SizedBox(height: 24),
                  TextFormField(
                    controller: _emailController,
                    decoration: InputDecoration(
                      labelText: 'Email',
                      border: const OutlineInputBorder(),
                      errorText: _emailError,
                      suffixIcon: _isCheckingEmail
                          ? const SizedBox(
                              width: 20,
                              height: 20,
                              child: Padding(
                                padding: EdgeInsets.all(8.0),
                                child:
                                    CircularProgressIndicator(strokeWidth: 2),
                              ),
                            )
                          : null,
                    ),
                    keyboardType: TextInputType.emailAddress,
                    validator: (value) {
                      if (value == null || value.isEmpty) {
                        return 'Please enter your email';
                      }
                      if (!value.contains('@')) {
                        return 'Please enter a valid email';
                      }
                      return null;
                    },
                    onChanged: _onEmailChanged,
                  ),
                  const SizedBox(height: 16),
                  TextFormField(
                    controller: _passwordController,
                    decoration: const InputDecoration(
                      labelText: 'Password',
                      border: OutlineInputBorder(),
                    ),
                    obscureText: true,
                    validator: (value) {
                      if (value == null || value.isEmpty) {
                        return 'Please enter your password';
                      }
                      if (value.length < 6) {
                        return 'Password must be at least 6 characters';
                      }
                      return null;
                    },
                  ),
                  const SizedBox(height: 16),
                  TextFormField(
                    controller: _confirmPasswordController,
                    decoration: const InputDecoration(
                      labelText: 'Confirm Password',
                      border: OutlineInputBorder(),
                    ),
                    obscureText: true,
                    validator: (value) {
                      if (value == null || value.isEmpty) {
                        return 'Please confirm your password';
                      }
                      if (value != _passwordController.text) {
                        return 'Passwords do not match';
                      }
                      return null;
                    },
                  ),
                  const SizedBox(height: 24),
                  ElevatedButton(
                    onPressed: _isLoading || _isCheckingEmail ? null : _signup,
                    child: _isLoading
                        ? const SizedBox(
                            height: 20,
                            width: 20,
                            child: CircularProgressIndicator(strokeWidth: 2),
                          )
                        : const Text('Sign up'),
                  ),
                  const SizedBox(height: 16),
                  const Text(
                    'or',
                    textAlign: TextAlign.center,
                  ),
                  const SizedBox(height: 16),
                  OutlinedButton.icon(
                    onPressed: () {
                      // TODO: Implement Google Sign In
                    },
                    icon: const Icon(Icons.login),
                    label: const Text('Continue with Google'),
                  ),
                ],
              ),
            ),
          ),
        ),
      ),
    );
  }
}
