import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import '../create_meal_state.dart';

class IngredientsStep extends StatefulWidget {
  const IngredientsStep({super.key});

  @override
  State<IngredientsStep> createState() => _IngredientsStepState();
}

class _IngredientsStepState extends State<IngredientsStep> {
  final searchController = TextEditingController();
  final quantityController = TextEditingController();
  final customIngredientController = TextEditingController();
  String selectedUnit = 'grams';

  @override
  void dispose() {
    searchController.dispose();
    quantityController.dispose();
    customIngredientController.dispose();
    super.dispose();
  }

  @override
  Widget build(BuildContext context) {
    final state = context.watch<CreateMealState>();

    return SingleChildScrollView(
      padding: const EdgeInsets.all(16),
      child: Column(
        crossAxisAlignment: CrossAxisAlignment.stretch,
        children: [
          TextField(
            controller: searchController,
            decoration: const InputDecoration(
              labelText: 'Search Ingredients',
              prefixIcon: Icon(Icons.search),
              border: OutlineInputBorder(),
            ),
            onChanged: (value) {
              // TODO: Implement ingredient search
            },
          ),
          const SizedBox(height: 16),
          const Text(
            'Selected Ingredients',
            style: TextStyle(
              fontSize: 18,
              fontWeight: FontWeight.bold,
            ),
          ),
          const SizedBox(height: 8),
          ListView.builder(
            shrinkWrap: true,
            physics: const NeverScrollableScrollPhysics(),
            itemCount: state.meal.ingredients.length,
            itemBuilder: (context, index) {
              final ingredient = state.meal.ingredients[index];
              return Card(
                child: ListTile(
                  title: Text(ingredient['name'] as String),
                  subtitle: Text(
                    '${ingredient['quantity']} ${ingredient['unit']}',
                  ),
                  trailing: IconButton(
                    icon: const Icon(Icons.delete),
                    onPressed: () => state.removeIngredient(index),
                  ),
                ),
              );
            },
          ),
          const SizedBox(height: 16),
          ExpansionTile(
            title: const Text('Add Custom Ingredient'),
            children: [
              Padding(
                padding: const EdgeInsets.all(16),
                child: Column(
                  children: [
                    TextField(
                      controller: customIngredientController,
                      decoration: const InputDecoration(
                        labelText: 'Ingredient Name',
                        border: OutlineInputBorder(),
                      ),
                    ),
                    const SizedBox(height: 8),
                    Row(
                      children: [
                        Expanded(
                          child: TextField(
                            controller: quantityController,
                            keyboardType: TextInputType.number,
                            decoration: const InputDecoration(
                              labelText: 'Quantity',
                              border: OutlineInputBorder(),
                            ),
                          ),
                        ),
                        const SizedBox(width: 8),
                        Expanded(
                          child: DropdownButtonFormField<String>(
                            decoration: const InputDecoration(
                              labelText: 'Unit',
                              border: OutlineInputBorder(),
                            ),
                            value: selectedUnit,
                            items: const [
                              DropdownMenuItem(
                                value: 'grams',
                                child: Text('Grams'),
                              ),
                              DropdownMenuItem(
                                value: 'pieces',
                                child: Text('Pieces'),
                              ),
                              DropdownMenuItem(
                                value: 'ml',
                                child: Text('Milliliters'),
                              ),
                            ],
                            onChanged: (value) {
                              if (value != null) {
                                setState(() {
                                  selectedUnit = value;
                                });
                              }
                            },
                          ),
                        ),
                      ],
                    ),
                    const SizedBox(height: 16),
                    ElevatedButton(
                      onPressed: () {
                        if (customIngredientController.text.isNotEmpty &&
                            quantityController.text.isNotEmpty) {
                          state.addIngredient({
                            'name': customIngredientController.text,
                            'quantity': double.parse(quantityController.text),
                            'unit': selectedUnit,
                          });
                          customIngredientController.clear();
                          quantityController.clear();
                        }
                      },
                      child: const Text('Add Ingredient'),
                    ),
                  ],
                ),
              ),
            ],
          ),
        ],
      ),
    );
  }
}