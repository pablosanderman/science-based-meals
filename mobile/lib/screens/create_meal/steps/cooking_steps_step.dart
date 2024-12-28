import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import '../create_meal_state.dart';

class CookingStepsStep extends StatefulWidget {
  const CookingStepsStep({super.key});

  @override
  State<CookingStepsStep> createState() => _CookingStepsStepState();
}

class _CookingStepsStepState extends State<CookingStepsStep> {
  final stepController = TextEditingController();

  @override
  void dispose() {
    stepController.dispose();
    super.dispose();
  }

  void _showEditDialog(BuildContext context, CreateMealState state, int index) {
    final editController = TextEditingController(
      text: state.meal.cookingSteps[index],
    );

    showDialog(
      context: context,
      builder: (context) => AlertDialog(
        title: const Text('Edit Step'),
        content: TextField(
          controller: editController,
          decoration: const InputDecoration(
            labelText: 'Step Description',
            border: OutlineInputBorder(),
          ),
          maxLines: 3,
        ),
        actions: [
          TextButton(
            onPressed: () => Navigator.pop(context),
            child: const Text('Cancel'),
          ),
          ElevatedButton(
            onPressed: () {
              if (editController.text.isNotEmpty) {
                state.updateCookingStep(index, editController.text);
                Navigator.pop(context);
              }
            },
            child: const Text('Save'),
          ),
        ],
      ),
    );
  }

  @override
  Widget build(BuildContext context) {
    final state = context.watch<CreateMealState>();

    return SingleChildScrollView(
      padding: const EdgeInsets.all(16),
      child: Column(
        crossAxisAlignment: CrossAxisAlignment.stretch,
        children: [
          Card(
            child: Padding(
              padding: const EdgeInsets.all(16),
              child: Column(
                crossAxisAlignment: CrossAxisAlignment.stretch,
                children: [
                  TextField(
                    controller: stepController,
                    decoration: const InputDecoration(
                      labelText: 'Add Cooking Step',
                      border: OutlineInputBorder(),
                    ),
                    maxLines: 3,
                  ),
                  const SizedBox(height: 16),
                  ElevatedButton.icon(
                    onPressed: () {
                      if (stepController.text.isNotEmpty) {
                        state.addCookingStep(stepController.text);
                        stepController.clear();
                      }
                    },
                    icon: const Icon(Icons.add),
                    label: const Text('Add Step'),
                  ),
                ],
              ),
            ),
          ),
          const SizedBox(height: 16),
          if (state.meal.cookingSteps.isNotEmpty) ...[
            const Text(
              'Cooking Steps',
              style: TextStyle(
                fontSize: 18,
                fontWeight: FontWeight.bold,
              ),
            ),
            const SizedBox(height: 8),
            ReorderableListView.builder(
              shrinkWrap: true,
              physics: const NeverScrollableScrollPhysics(),
              itemCount: state.meal.cookingSteps.length,
              onReorder: state.reorderCookingSteps,
              itemBuilder: (context, index) {
                return Card(
                  key: ValueKey(index),
                  child: ListTile(
                    leading: CircleAvatar(
                      child: Text('${index + 1}'),
                    ),
                    title: Text(state.meal.cookingSteps[index]),
                    trailing: Row(
                      mainAxisSize: MainAxisSize.min,
                      children: [
                        IconButton(
                          icon: const Icon(Icons.edit),
                          onPressed: () {
                            _showEditDialog(context, state, index);
                          },
                        ),
                        IconButton(
                          icon: const Icon(Icons.delete),
                          onPressed: () => state.removeCookingStep(index),
                        ),
                      ],
                    ),
                  ),
                );
              },
            ),
          ],
        ],
      ),
    );
  }
}
