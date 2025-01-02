import 'dart:io';

class Meal {
  File? image;
  String name;
  List<Map<String, dynamic>> ingredients;
  List<String> cookingSteps;
  List<String> references;
  String visibility;

  Meal({
    this.image,
    this.name = '',
    List<Map<String, dynamic>>? ingredients,
    List<String>? cookingSteps,
    List<String>? references,
    this.visibility = 'public_unapproved',
  })  : ingredients = ingredients ?? [],
        cookingSteps = cookingSteps ?? [],
        references = references ?? [];

  Map<String, dynamic> toJson() {
    return {
      'name': name,
      'ingredients': ingredients,
      'cookingSteps': cookingSteps,
      'references': references,
      'visibility': visibility,
    };
  }

  factory Meal.fromJson(Map<String, dynamic> json) {
    return Meal(
      name: json['name'] as String,
      ingredients: (json['ingredients'] as List).cast<Map<String, dynamic>>(),
      cookingSteps: (json['cookingSteps'] as List).cast<String>(),
      references: (json['references'] as List).cast<String>(),
      visibility: json['visibility'] as String,
    );
  }
}
