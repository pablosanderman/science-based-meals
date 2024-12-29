import 'dart:convert';
import 'package:http/http.dart' as http;
import 'dart:developer' as developer;

import 'package:science_based_meals/config.dart';

class IngredientService {
  static const String baseUrl = Config.apiBaseUrl;

  Future<List<Map<String, dynamic>>> searchIngredients(String query) async {
    if (query.isEmpty) {
      return [];
    }

    try {
      final response = await http.get(
        Uri.parse('$baseUrl/ingredients/search?query=$query'),
      );

      if (response.statusCode == 200) {
        final List<dynamic> data = json.decode(response.body);
        return data.cast<Map<String, dynamic>>();
      }
      return [];
    } catch (e) {
      developer.log('Error searching ingredients: $e');
      return [];
    }
  }
}
