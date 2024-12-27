import 'package:flutter/material.dart';

class UsernameModal extends StatefulWidget {
  const UsernameModal({super.key});

  @override
  State<UsernameModal> createState() => _UsernameModalState();
}

class _UsernameModalState extends State<UsernameModal> {
  final _formKey = GlobalKey<FormState>();
  final _usernameController = TextEditingController();
  String? _errorText;

  @override
  void dispose() {
    _usernameController.dispose();
    super.dispose();
  }

  bool _isValidUsername(String value) {
    final regex = RegExp(r'^[a-zA-Z0-9_-]+$');
    return regex.hasMatch(value);
  }

  @override
  Widget build(BuildContext context) {
    return AlertDialog(
      title: const Text('Choose your username'),
      content: Form(
        key: _formKey,
        child: Column(
          mainAxisSize: MainAxisSize.min,
          children: [
            TextFormField(
              controller: _usernameController,
              decoration: InputDecoration(
                labelText: 'Username',
                errorText: _errorText,
                border: const OutlineInputBorder(),
                helperText: 'Letters, numbers, underscores, and hyphens only',
              ),
              validator: (value) {
                if (value == null || value.isEmpty) {
                  return 'Please enter a username';
                }
                if (value.length < 3) {
                  return 'Username must be at least 3 characters';
                }
                if (value.length > 50) {
                  return 'Username must be less than 50 characters';
                }
                if (!_isValidUsername(value)) {
                  return 'Username can only contain letters, numbers, underscores, and hyphens';
                }
                return null;
              },
            ),
          ],
        ),
      ),
      actions: [
        TextButton(
          onPressed: () => Navigator.of(context).pop(),
          child: const Text('Cancel'),
        ),
        ElevatedButton(
          onPressed: () {
            if (_formKey.currentState!.validate()) {
              Navigator.of(context).pop(_usernameController.text);
            }
          },
          child: const Text('Continue'),
        ),
      ],
    );
  }
}
