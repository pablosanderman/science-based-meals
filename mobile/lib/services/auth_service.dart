import 'dart:convert';
import 'dart:developer' as developer;
import 'package:http/http.dart' as http;
import 'package:flutter_secure_storage/flutter_secure_storage.dart';
import 'package:science_based_meals/config.dart';
import '../models/user.dart';

class AuthService {
  final String baseUrl = Config.apiBaseUrl;
  final storage = const FlutterSecureStorage();

  Future<bool> isEmailAvailable(String email) async {
    try {
      developer.log(
        'Checking email availability: $email',
        name: 'AuthService',
        level: 800,
      );

      final response = await http.get(
        Uri.parse('$baseUrl/users/check-email?email=$email'),
        headers: {'Content-Type': 'application/json'},
      );

      developer.log(
        'Email check response: ${response.statusCode}\nBody: ${response.body}',
        name: 'AuthService',
        level: 800,
      );

      if (response.statusCode == 200) {
        final body = jsonDecode(response.body);
        return body['available'] == true;
      }
      return false;
    } catch (e) {
      developer.log(
        'Email check error',
        error: e,
        name: 'AuthService',
        level: 1000,
      );
      return false;
    }
  }

  Future<AuthResponse> login(String email, String password) async {
    try {
      developer.log(
        'Attempting login',
        name: 'AuthService',
        error: null,
        level: 800,
      );

      final response = await http.post(
        Uri.parse('$baseUrl/users/login'),
        headers: {'Content-Type': 'application/json'},
        body: jsonEncode(LoginDto(email: email, password: password).toJson()),
      );

      developer.log(
        'Login response received: ${response.statusCode}\nBody: ${response.body}',
        name: 'AuthService',
        error: response.statusCode >= 400 ? response.body : null,
        level: response.statusCode >= 400 ? 1000 : 800,
      );

      if (response.statusCode == 200) {
        final authResponse = AuthResponse.fromJson(jsonDecode(response.body));
        await storage.write(key: 'token', value: authResponse.token);
        return authResponse;
      } else {
        final errorBody = jsonDecode(response.body);
        throw Exception(
            errorBody['error'] ?? 'Failed to login: ${response.body}');
      }
    } catch (e) {
      developer.log(
        'Login error occurred',
        error: e,
        name: 'AuthService',
        level: 1000,
      );
      rethrow;
    }
  }

  Future<AuthResponse> register(
      String email, String password, String username) async {
    try {
      final requestBody = CreateUserDto(
        email: email,
        password: password,
        username: username,
      ).toJson();

      developer.log(
        'Registration request body: ${jsonEncode(requestBody)}',
        name: 'AuthService',
        level: 800,
      );

      final response = await http.post(
        Uri.parse('$baseUrl/users'),
        headers: {'Content-Type': 'application/json'},
        body: jsonEncode(requestBody),
      );

      if (response.statusCode == 201) {
        final authResponse = AuthResponse.fromJson(jsonDecode(response.body));
        await storage.write(key: 'token', value: authResponse.token);
        return authResponse;
      } else {
        final errorBody = jsonDecode(response.body);
        throw Exception(
            errorBody['error'] ?? 'Failed to register: ${response.body}');
      }
    } catch (e) {
      rethrow;
    }
  }

  Future<void> logout() async {
    try {
      developer.log(
        'User logged out',
        name: 'AuthService',
        level: 800,
      );
      await storage.delete(key: 'token');
    } catch (e) {
      developer.log(
        'Logout error occurred',
        error: e,
        name: 'AuthService',
        level: 1000,
      );
      rethrow;
    }
  }

  Future<String?> getToken() async {
    return await storage.read(key: 'token');
  }

  Future<bool> isAuthenticated() async {
    final token = await getToken();
    return token != null;
  }
}
