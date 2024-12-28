import 'dart:io';
import 'package:flutter/material.dart';
import 'package:science_based_meals/config.dart';
import '../../models/meal_model.dart';
import 'package:http/http.dart' as http;
import 'dart:convert';
import '../../services/auth_service.dart';
import 'package:http_parser/http_parser.dart';

class CreateMealState extends ChangeNotifier {
  final AuthService _authService = AuthService();
  final Meal meal = Meal();
  int currentStep = 0;

  void reset() {
    meal.image = null;
    meal.name = '';
    meal.ingredients.clear();
    meal.cookingSteps.clear();
    meal.references.clear();
    meal.visibility = 'public_unapproved';
    currentStep = 0;
    notifyListeners();
  }

  void updateMealImage(File image) {
    meal.image = image;
    notifyListeners();
  }

  void updateMealName(String name) {
    meal.name = name;
    notifyListeners();
  }

  void addIngredient(Map<String, dynamic> ingredient) {
    meal.ingredients.add(ingredient);
    notifyListeners();
  }

  void removeIngredient(int index) {
    meal.ingredients.removeAt(index);
    notifyListeners();
  }

  void addCookingStep(String step) {
    meal.cookingSteps.add(step);
    notifyListeners();
  }

  void removeCookingStep(int index) {
    meal.cookingSteps.removeAt(index);
    notifyListeners();
  }

  void reorderCookingSteps(int oldIndex, int newIndex) {
    if (oldIndex < newIndex) {
      newIndex -= 1;
    }
    final steps = List<String>.from(meal.cookingSteps);
    final step = steps.removeAt(oldIndex);
    steps.insert(newIndex, step);
    meal.cookingSteps.clear();
    meal.cookingSteps.addAll(steps);
    notifyListeners();
  }

  void updateCookingStep(int index, String newStep) {
    meal.cookingSteps[index] = newStep;
    notifyListeners();
  }

  void addReference(String reference) {
    meal.references.add(reference);
    notifyListeners();
  }

  void removeReference(int index) {
    meal.references.removeAt(index);
    notifyListeners();
  }

  void updateVisibility(String visibility) {
    meal.visibility = visibility;
    notifyListeners();
  }

  void setCurrentStep(int step) {
    currentStep = step;
    notifyListeners();
  }

  bool canProceedToNextStep() {
    switch (currentStep) {
      case 0:
        return meal.image != null && meal.name.isNotEmpty;
      case 1:
        return meal.ingredients.isNotEmpty;
      case 2:
        return meal.cookingSteps.isNotEmpty;
      case 3:
        return true; // References are optional
      case 4:
        // On the final step, ensure all required fields are filled
        return meal.image != null &&
            meal.name.isNotEmpty &&
            meal.ingredients.isNotEmpty &&
            meal.cookingSteps.isNotEmpty;
      default:
        return false;
    }
  }

  Future<bool> saveMeal() async {
    try {
      // Check if user is authenticated
      final isAuthenticated = await _authService.isAuthenticated();

      if (!isAuthenticated) {
        return false;
      }

      final token = await _authService.getToken();

      final url = Uri.parse('${Config.apiBaseUrl}/MealCreation/CreateMeal');

      // Create multipart request
      var request = http.MultipartRequest('POST', url);

      // Add headers
      request.headers.addAll({
        'Authorization': 'Bearer $token',
      });

      // Add image file if exists
      if (meal.image != null) {
        var stream = meal.image!.openRead();
        var length = await meal.image!.length();

        var multipartFile = http.MultipartFile(
          'Image',
          stream,
          length,
          filename: 'meal_image.jpg',
          contentType: MediaType('image', 'jpeg'),
        );
        request.files.add(multipartFile);
      }

      // Add meal data as form fields
      request.fields['Name'] = meal.name;
      request.fields['Version'] = '1.0';
      request.fields['Instructions'] = meal.cookingSteps.join('\n');

      // Add ingredients as JSON string
      final ingredients = meal.ingredients.map((ingredient) {
        return {
          'ingredientId': ingredient['ingredientId'],
          'amount': ingredient['amount'].toString(),
          'unit': ingredient['unit']
        };
      }).toList();
      request.fields['Ingredients'] = jsonEncode(ingredients);

      // Add references as JSON string
      request.fields['References'] = jsonEncode(meal.references);

      // Send the request
      final response = await request.send();
      final responseStr = await response.stream.bytesToString();

      if (response.statusCode == 201) {
        return true;
      } else {
        return false;
      }
    } catch (e) {
      return false;
    }
  }
}
