import 'dart:io';
import 'package:flutter/material.dart';
import 'package:image_picker/image_picker.dart';
import 'package:provider/provider.dart';
import '../create_meal_state.dart';

class MealPhotoNameStep extends StatelessWidget {
  const MealPhotoNameStep({super.key});

  @override
  Widget build(BuildContext context) {
    final state = context.watch<CreateMealState>();

    return SingleChildScrollView(
      padding: const EdgeInsets.all(16),
      child: Column(
        crossAxisAlignment: CrossAxisAlignment.stretch,
        children: [
          GestureDetector(
            onTap: () async {
              final ImagePicker picker = ImagePicker();
              final XFile? image = await picker.pickImage(
                source: ImageSource.gallery,
                maxWidth: 1000,
                maxHeight: 1000,
              );
              if (image != null) {
                state.updateMealImage(File(image.path));
              }
            },
            child: Container(
              height: 200,
              decoration: BoxDecoration(
                color: Colors.grey[200],
                borderRadius: BorderRadius.circular(8),
              ),
              child: state.meal.image != null
                  ? ClipRRect(
                      borderRadius: BorderRadius.circular(8),
                      child: Image.file(
                        state.meal.image!,
                        fit: BoxFit.cover,
                      ),
                    )
                  : const Icon(
                      Icons.add_a_photo,
                      size: 48,
                      color: Colors.grey,
                    ),
            ),
          ),
          const SizedBox(height: 16),
          TextFormField(
            initialValue: state.meal.name,
            decoration: const InputDecoration(
              labelText: 'Meal Name',
              border: OutlineInputBorder(),
            ),
            validator: (value) {
              if (value == null || value.isEmpty) {
                return 'Please enter a meal name';
              }
              return null;
            },
            onChanged: state.updateMealName,
          ),
        ],
      ),
    );
  }
}
