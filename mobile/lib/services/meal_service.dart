import 'dart:convert';
import 'package:http/http.dart' as http;
import '../config.dart';
import '../models/meal.dart';

class MealService {
  final String baseUrl = Config.apiBaseUrl;

  Future<List<Meal>> searchMeals({
    required String query,
    bool? isApproved,
    int page = 1,
    int pageSize = 20,
  }) async {
    final queryParams = {
      'query': query,
      'page': page.toString(),
      'pageSize': pageSize.toString(),
      if (isApproved != null)
        'visibility': isApproved ? 'public_approved' : 'public_unapproved',
    };

    final response = await http.get(
      Uri.parse('$baseUrl/meals/search').replace(queryParameters: queryParams),
    );

    if (response.statusCode == 200) {
      final List<dynamic> data = json.decode(response.body);
      return data.map((json) => Meal.fromJson(json)).toList();
    } else {
      throw Exception('Failed to search meals');
    }
  }
}
