import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import '../create_meal_state.dart';

class SaveMealStep extends StatelessWidget {
  const SaveMealStep({super.key});

  @override
  Widget build(BuildContext context) {
    final state = context.watch<CreateMealState>();

    return Padding(
      padding: const EdgeInsets.all(16),
      child: Column(
        crossAxisAlignment: CrossAxisAlignment.stretch,
        children: [
          const Text(
            'Save Options',
            style: TextStyle(
              fontSize: 18,
              fontWeight: FontWeight.bold,
            ),
          ),
          const SizedBox(height: 16),
          DropdownButtonFormField<String>(
            decoration: const InputDecoration(
              labelText: 'Save Option',
              border: OutlineInputBorder(),
            ),
            value: state.meal.visibility,
            items: const [
              DropdownMenuItem(
                value: 'private',
                child: Text('Save as Private'),
              ),
              DropdownMenuItem(
                value: 'public_unapproved',
                child: Text('Make Public (Unapproved)'),
              ),
              DropdownMenuItem(
                value: 'request_approval',
                child: Text('Request Approval'),
              ),
            ],
            onChanged: (value) {
              if (value != null) state.updateVisibility(value);
            },
          ),
          const SizedBox(height: 24),
          const Text(
            'Summary',
            style: TextStyle(
              fontSize: 18,
              fontWeight: FontWeight.bold,
            ),
          ),
          const SizedBox(height: 16),
          _buildSummaryItem('Name', state.meal.name),
          _buildSummaryItem(
            'Ingredients',
            '${state.meal.ingredients.length} ingredients',
          ),
          _buildSummaryItem(
            'Cooking Steps',
            '${state.meal.cookingSteps.length} steps',
          ),
          _buildSummaryItem(
            'References',
            '${state.meal.references.length} references',
          ),
        ],
      ),
    );
  }

  Widget _buildSummaryItem(String label, String value) {
    return Padding(
      padding: const EdgeInsets.symmetric(vertical: 8),
      child: Row(
        mainAxisAlignment: MainAxisAlignment.spaceBetween,
        children: [
          Text(
            label,
            style: const TextStyle(
              fontWeight: FontWeight.w500,
            ),
          ),
          Text(value),
        ],
      ),
    );
  }
}
