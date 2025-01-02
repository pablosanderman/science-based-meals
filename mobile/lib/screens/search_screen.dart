import 'package:flutter/material.dart';
import 'dart:async';
import '../models/meal.dart';
import '../services/meal_service.dart';
import 'filters_screen.dart';
import 'meal_details_screen.dart';

class SearchScreen extends StatefulWidget {
  const SearchScreen({super.key});

  @override
  State<SearchScreen> createState() => _SearchScreenState();
}

class _SearchScreenState extends State<SearchScreen> {
  final _searchController = TextEditingController();
  final _mealService = MealService();
  Timer? _debounce;
  List<Meal> _meals = [];
  bool _isLoading = false;
  bool? _approvalFilter;

  @override
  void dispose() {
    _searchController.dispose();
    _debounce?.cancel();
    super.dispose();
  }

  Future<void> _performSearch() async {
    if (_searchController.text.isEmpty) {
      setState(() => _meals = []);
      return;
    }

    setState(() => _isLoading = true);
    try {
      final results = await _mealService.searchMeals(
        query: _searchController.text,
        isApproved: _approvalFilter,
      );
      if (mounted) {
        setState(() => _meals = results);
      }
    } catch (e) {
      if (mounted) {
        ScaffoldMessenger.of(context).showSnackBar(
          const SnackBar(content: Text('Failed to search meals')),
        );
      }
    } finally {
      if (mounted) {
        setState(() => _isLoading = false);
      }
    }
  }

  void _onSearchChanged(String query) {
    if (_debounce?.isActive ?? false) _debounce!.cancel();
    _debounce = Timer(const Duration(milliseconds: 500), _performSearch);
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: TextField(
          controller: _searchController,
          onChanged: _onSearchChanged,
          decoration: const InputDecoration(
            hintText: 'Search meals...',
            border: InputBorder.none,
            hintStyle: TextStyle(color: Colors.black54),
          ),
        ),
      ),
      body: Column(
        children: [
          Padding(
            padding: const EdgeInsets.all(8.0),
            child: Row(
              children: [
                TextButton.icon(
                  onPressed: () {
                    Navigator.push(
                      context,
                      MaterialPageRoute(builder: (_) => const FiltersScreen()),
                    );
                  },
                  icon: const Icon(Icons.filter_list),
                  label: const Text('Filters'),
                ),
                const Spacer(),
                FilterChip(
                  label: const Text('Approved'),
                  selected: _approvalFilter == true,
                  onSelected: (selected) {
                    setState(() {
                      _approvalFilter = selected ? true : null;
                      _performSearch();
                    });
                  },
                ),
                const SizedBox(width: 8),
                FilterChip(
                  label: const Text('Unapproved'),
                  selected: _approvalFilter == false,
                  onSelected: (selected) {
                    setState(() {
                      _approvalFilter = selected ? false : null;
                      _performSearch();
                    });
                  },
                ),
              ],
            ),
          ),
          Expanded(
            child: _isLoading
                ? const Center(child: CircularProgressIndicator())
                : ListView.builder(
                    itemCount: _meals.length,
                    itemBuilder: (context, index) {
                      final meal = _meals[index];
                      return Card(
                        margin: const EdgeInsets.symmetric(
                          horizontal: 8.0,
                          vertical: 4.0,
                        ),
                        child: ListTile(
                          leading: meal.image != null
                              ? Image.file(
                                  meal.image!,
                                  width: 56,
                                  height: 56,
                                  fit: BoxFit.cover,
                                )
                              : Container(
                                  width: 56,
                                  height: 56,
                                  color: Colors.grey[300],
                                  child: const Icon(Icons.restaurant),
                                ),
                          title: Text(meal.name),
                          subtitle: Text(
                            'Ingredients: ${meal.ingredients.length}',
                          ),
                          trailing: ElevatedButton(
                            onPressed: () {
                              Navigator.push(
                                context,
                                MaterialPageRoute(
                                  builder: (_) => MealDetailsScreen(meal: meal),
                                ),
                              );
                            },
                            child: const Text('View'),
                          ),
                        ),
                      );
                    },
                  ),
          ),
        ],
      ),
    );
  }
}
