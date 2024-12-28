import 'dart:io';
import 'package:flutter/material.dart';
import '../../models/meal_model.dart';

class CreateMealState extends ChangeNotifier {
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
      // TODO: Implement API call to save meal
      return true;
    } catch (e) {
      return false;
    }
  }
}
