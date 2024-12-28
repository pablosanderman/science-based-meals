import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import '../create_meal_state.dart';
import '../../../services/ingredient_service.dart';

class IngredientsStep extends StatefulWidget {
  const IngredientsStep({super.key});

  @override
  State<IngredientsStep> createState() => _IngredientsStepState();
}

class _IngredientsStepState extends State<IngredientsStep> {
  final searchController = TextEditingController();
  final quantityController = TextEditingController();
  String selectedUnit = 'grams';
  final _formKey = GlobalKey<FormState>();
  final _ingredientService = IngredientService();
  List<Map<String, dynamic>> searchResults = [];
  bool isSearching = false;

  @override
  void dispose() {
    searchController.dispose();
    quantityController.dispose();
    super.dispose();
  }

  double? _parseQuantity(String value) {
    try {
      return double.parse(value.trim());
    } catch (e) {
      return null;
    }
  }

  void _addIngredient(
      CreateMealState state, Map<String, dynamic> searchResult) {
    if (_formKey.currentState?.validate() ?? false) {
      final quantity = _parseQuantity(quantityController.text);
      if (quantity != null) {
        state.addIngredient({
          'id': searchResult['id'],
          'name': searchResult['name'],
          'quantity': quantity,
          'unit': selectedUnit,
          'nutrients': searchResult['nutrients'],
        });
        searchController.clear();
        quantityController.clear();
        setState(() {
          searchResults = [];
        });
      }
    }
  }

  Future<void> _searchIngredients(String query) async {
    setState(() {
      isSearching = true;
    });

    try {
      final results = await _ingredientService.searchIngredients(query);
      setState(() {
        searchResults = results;
        isSearching = false;
      });
    } catch (e) {
      setState(() {
        searchResults = [];
        isSearching = false;
      });
    }
  }

  @override
  Widget build(BuildContext context) {
    final state = context.watch<CreateMealState>();

    return SingleChildScrollView(
      padding: const EdgeInsets.all(16),
      child: Form(
        key: _formKey,
        child: Column(
          crossAxisAlignment: CrossAxisAlignment.stretch,
          children: [
            TextField(
              controller: searchController,
              decoration: InputDecoration(
                labelText: 'Search Ingredients',
                prefixIcon: const Icon(Icons.search),
                suffixIcon: isSearching
                    ? const SizedBox(
                        width: 20,
                        height: 20,
                        child: CircularProgressIndicator(strokeWidth: 2),
                      )
                    : null,
                border: const OutlineInputBorder(),
              ),
              onChanged: (value) {
                if (value.length >= 2) {
                  _searchIngredients(value);
                } else {
                  setState(() {
                    searchResults = [];
                  });
                }
              },
            ),
            if (searchResults.isNotEmpty) ...[
              const SizedBox(height: 8),
              Card(
                child: Column(
                  children: searchResults.map((result) {
                    return ListTile(
                      title: Text(result['name']),
                      subtitle: Text(result['description']),
                      onTap: () {
                        showDialog(
                          context: context,
                          builder: (context) => AlertDialog(
                            title: Text('Add ${result['name']}'),
                            content: Column(
                              mainAxisSize: MainAxisSize.min,
                              children: [
                                TextFormField(
                                  controller: quantityController,
                                  keyboardType:
                                      const TextInputType.numberWithOptions(
                                          decimal: true),
                                  decoration: const InputDecoration(
                                    labelText: 'Quantity',
                                    border: OutlineInputBorder(),
                                  ),
                                  validator: (value) {
                                    if (value == null || value.trim().isEmpty) {
                                      return 'Please enter a quantity';
                                    }
                                    if (_parseQuantity(value) == null) {
                                      return 'Please enter a valid number';
                                    }
                                    return null;
                                  },
                                ),
                                const SizedBox(height: 8),
                                DropdownButtonFormField<String>(
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
                              ],
                            ),
                            actions: [
                              TextButton(
                                onPressed: () => Navigator.pop(context),
                                child: const Text('Cancel'),
                              ),
                              TextButton(
                                onPressed: () {
                                  _addIngredient(state, result);
                                  Navigator.pop(context);
                                },
                                child: const Text('Add'),
                              ),
                            ],
                          ),
                        );
                      },
                    );
                  }).toList(),
                ),
              ),
            ],
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
          ],
        ),
      ),
    );
  }
}
