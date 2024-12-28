import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import '../create_meal_state.dart';

class ReferenceLinksStep extends StatefulWidget {
  const ReferenceLinksStep({super.key});

  @override
  State<ReferenceLinksStep> createState() => _ReferenceLinksStepState();
}

class _ReferenceLinksStepState extends State<ReferenceLinksStep> {
  final _formKey = GlobalKey<FormState>();
  final _referenceController = TextEditingController();

  @override
  void dispose() {
    _referenceController.dispose();
    super.dispose();
  }

  String? _validateUrl(String? value) {
    if (value != null && value.isNotEmpty) {
      final urlPattern = RegExp(r'https?://[^\s/$.?#].[^\s]*');
      if (!urlPattern.hasMatch(value)) {
        return 'Please enter a valid URL';
      }
    }
    return null;
  }

  void _addReference(CreateMealState state) {
    if (_formKey.currentState!.validate() &&
        _referenceController.text.isNotEmpty) {
      state.addReference(_referenceController.text);
      _referenceController.clear();
    }
  }

  @override
  Widget build(BuildContext context) {
    return Consumer<CreateMealState>(
      builder: (context, state, child) {
        return SingleChildScrollView(
          padding: const EdgeInsets.all(16.0),
          child: Form(
            key: _formKey,
            child: Column(
              crossAxisAlignment: CrossAxisAlignment.stretch,
              children: [
                const Text(
                  'Add References (Optional)',
                  style: TextStyle(
                    fontSize: 18,
                    fontWeight: FontWeight.bold,
                  ),
                ),
                const SizedBox(height: 16),
                TextFormField(
                  controller: _referenceController,
                  decoration: const InputDecoration(
                    labelText: 'Reference Link',
                    hintText: 'Enter a URL to a research paper or article',
                    border: OutlineInputBorder(),
                  ),
                  validator: _validateUrl,
                ),
                const SizedBox(height: 8),
                ElevatedButton.icon(
                  onPressed: () => _addReference(state),
                  icon: const Icon(Icons.add_link),
                  label: const Text('Add Reference'),
                ),
                const SizedBox(height: 24),
                if (state.meal.references.isNotEmpty)
                  ListView.builder(
                    shrinkWrap: true,
                    physics: const NeverScrollableScrollPhysics(),
                    itemCount: state.meal.references.length,
                    itemBuilder: (context, index) {
                      return Card(
                        child: ListTile(
                          leading: const Icon(Icons.link),
                          title: Text(
                            state.meal.references[index],
                            maxLines: 1,
                            overflow: TextOverflow.ellipsis,
                          ),
                          trailing: IconButton(
                            icon: const Icon(Icons.delete),
                            onPressed: () => state.removeReference(index),
                          ),
                        ),
                      );
                    },
                  )
                else
                  const Padding(
                    padding: EdgeInsets.symmetric(vertical: 32),
                    child: Center(
                      child: Text(
                        'No references added yet',
                        style: TextStyle(
                          color: Colors.grey,
                          fontSize: 16,
                        ),
                      ),
                    ),
                  ),
              ],
            ),
          ),
        );
      },
    );
  }
}
