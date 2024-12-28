import 'dart:convert';
import 'package:http/http.dart' as http;

class IngredientService {
  static const String baseUrl = 'http://localhost:8080/api';

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
      print('Error searching ingredients: $e');
      return [];
    }
  }
}
