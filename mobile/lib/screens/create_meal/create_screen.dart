import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'create_meal_state.dart';
import 'steps/meal_photo_name_step.dart';
import 'steps/ingredients_step.dart';
import 'steps/cooking_steps_step.dart';
import 'steps/reference_links_step.dart';
import 'steps/save_meal_step.dart';

class CreateScreen extends StatelessWidget {
  const CreateScreen({super.key});

  @override
  Widget build(BuildContext context) {
    return ChangeNotifierProvider(
      create: (_) => CreateMealState(),
      child: const CreateScreenContent(),
    );
  }
}

class CreateScreenContent extends StatelessWidget {
  const CreateScreenContent({super.key});

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text('Create New Meal'),
      ),
      body: Consumer<CreateMealState>(
        builder: (context, state, _) {
          return Column(
            children: [
              _buildProgressIndicator(state, context),
              Expanded(
                child: _buildCurrentStep(state),
              ),
              _buildNavigationButtons(state, context),
            ],
          );
        },
      ),
    );
  }

  Widget _buildProgressIndicator(CreateMealState state, BuildContext context) {
    return Padding(
      padding: const EdgeInsets.all(16),
      child: Row(
        children: List.generate(
          5,
          (index) => Expanded(
            child: Container(
              margin: const EdgeInsets.symmetric(horizontal: 4),
              height: 4,
              decoration: BoxDecoration(
                color: index <= state.currentStep
                    ? Theme.of(context).primaryColor
                    : Colors.grey[300],
                borderRadius: BorderRadius.circular(2),
              ),
            ),
          ),
        ),
      ),
    );
  }

  Widget _buildCurrentStep(CreateMealState state) {
    return IndexedStack(
      index: state.currentStep,
      children: const [
        MealPhotoNameStep(),
        IngredientsStep(),
        CookingStepsStep(),
        ReferenceLinksStep(),
        SaveMealStep(),
      ],
    );
  }

  Widget _buildNavigationButtons(CreateMealState state, BuildContext context) {
    final bool isLastStep = state.currentStep == 4;
    final bool canProceed = state.canProceedToNextStep();

    return Padding(
      padding: const EdgeInsets.all(16),
      child: Row(
        mainAxisAlignment: MainAxisAlignment.spaceBetween,
        children: [
          if (state.currentStep > 0)
            TextButton(
              onPressed: () => state.setCurrentStep(state.currentStep - 1),
              child: const Text('Back'),
            )
          else
            const SizedBox(width: 80), // Placeholder for spacing
          ElevatedButton(
            onPressed:
                canProceed ? () => _handleNavigation(state, context) : null,
            child: Text(isLastStep ? 'Save' : 'Next'),
          ),
        ],
      ),
    );
  }

  Future<void> _handleNavigation(
      CreateMealState state, BuildContext context) async {
    if (state.currentStep < 4) {
      state.setCurrentStep(state.currentStep + 1);
      return;
    }

    final success = await state.saveMeal();
    if (!context.mounted) return;

    ScaffoldMessenger.of(context).showSnackBar(
      SnackBar(
        content: Text(
          success ? 'Meal saved successfully!' : 'Failed to save meal',
        ),
      ),
    );

    if (success) {
      Navigator.pop(context);
    }
  }
}
