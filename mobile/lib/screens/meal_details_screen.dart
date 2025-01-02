import 'package:flutter/material.dart';
import '../models/meal.dart';

class MealDetailsScreen extends StatelessWidget {
  final Meal meal;

  const MealDetailsScreen({
    super.key,
    required this.meal,
  });

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text(meal.name),
      ),
      body: const Center(
        child: Text(
          'Meal Details Coming Soon',
          style: TextStyle(fontSize: 24),
        ),
      ),
    );
  }
}
