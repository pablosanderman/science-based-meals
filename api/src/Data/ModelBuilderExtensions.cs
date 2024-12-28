using Microsoft.EntityFrameworkCore;
using ScienceBasedMealsApi.Models;

namespace ScienceBasedMealsApi.Data;

public static class ModelBuilderExtensions
{
  public static void SeedData(this ModelBuilder modelBuilder)
  {
    SeedUnits(modelBuilder);
    SeedNutrients(modelBuilder);
    SeedIngredients(modelBuilder);
    SeedIngredientNutrients(modelBuilder);
  }

  private static void SeedUnits(ModelBuilder modelBuilder)
  {
    modelBuilder.Entity<Unit>().HasData(
        new Unit { Id = 1, Name = "g", Description = "Grams" },
        new Unit { Id = 2, Name = "mg", Description = "Milligrams" },
        new Unit { Id = 3, Name = "µg", Description = "Micrograms" },
        new Unit { Id = 4, Name = "IU", Description = "International Units" },
        new Unit { Id = 5, Name = "kcal", Description = "Kilocalories" },
        new Unit { Id = 6, Name = "pieces", Description = "Pieces" },
        new Unit { Id = 7, Name = "ml", Description = "Milliliters" }
    );
  }

  private static void SeedNutrients(ModelBuilder modelBuilder)
  {
    modelBuilder.Entity<Nutrient>().HasData(
        new Nutrient { Id = 1, Name = "Calories", UnitId = 5, DailyValue = 2000 },
        new Nutrient { Id = 2, Name = "Protein", UnitId = 1, DailyValue = 50 },
        new Nutrient { Id = 3, Name = "Total Fat", UnitId = 1, DailyValue = 65 },
        new Nutrient { Id = 4, Name = "Saturated Fat", UnitId = 1, DailyValue = 20 },
        new Nutrient { Id = 5, Name = "Carbohydrates", UnitId = 1, DailyValue = 300 },
        new Nutrient { Id = 6, Name = "Fiber", UnitId = 1, DailyValue = 25 },
        new Nutrient { Id = 7, Name = "Sugar", UnitId = 1, DailyValue = 50 },
        new Nutrient { Id = 8, Name = "Sodium", UnitId = 2, DailyValue = 2300 },
        new Nutrient { Id = 9, Name = "Potassium", UnitId = 2, DailyValue = 3500 },
        new Nutrient { Id = 10, Name = "Vitamin A", UnitId = 4, DailyValue = 5000 },
        new Nutrient { Id = 11, Name = "Vitamin C", UnitId = 2, DailyValue = 60 },
        new Nutrient { Id = 12, Name = "Calcium", UnitId = 2, DailyValue = 1000 },
        new Nutrient { Id = 13, Name = "Iron", UnitId = 2, DailyValue = 18 },
        new Nutrient { Id = 14, Name = "Vitamin D", UnitId = 4, DailyValue = 400 },
        new Nutrient { Id = 15, Name = "Vitamin B12", UnitId = 3, DailyValue = 6 }
    );
  }

  private static void SeedIngredients(ModelBuilder modelBuilder)
  {
    var ingredients = new List<Ingredient>();
    var baseDate = DateTime.UtcNow.Date;

    // Vegetables
    for (int i = 1; i <= 40; i++)
    {
      ingredients.Add(CreateIngredient(i, GetVegetableName(i), "Fresh vegetable", baseDate));
    }

    // Fruits
    for (int i = 41; i <= 80; i++)
    {
      ingredients.Add(CreateIngredient(i, GetFruitName(i - 40), "Fresh fruit", baseDate));
    }

    // Proteins
    for (int i = 81; i <= 120; i++)
    {
      ingredients.Add(CreateIngredient(i, GetProteinName(i - 80), "Protein source", baseDate));
    }

    // Grains
    for (int i = 121; i <= 160; i++)
    {
      ingredients.Add(CreateIngredient(i, GetGrainName(i - 120), "Grain product", baseDate));
    }

    // Dairy
    for (int i = 161; i <= 200; i++)
    {
      ingredients.Add(CreateIngredient(i, GetDairyName(i - 160), "Dairy product", baseDate));
    }

    modelBuilder.Entity<Ingredient>().HasData(ingredients);
  }

  private static void SeedIngredientNutrients(ModelBuilder modelBuilder)
  {
    var ingredientNutrients = new List<IngredientNutrient>();
    var random = new Random(123); // Fixed seed for reproducibility

    // For each ingredient
    for (int ingredientId = 1; ingredientId <= 200; ingredientId++)
    {
      // Add nutrients with realistic values
      // Calories (always present)
      ingredientNutrients.Add(new IngredientNutrient
      {
        IngredientId = ingredientId,
        NutrientId = 1, // Calories
        Amount = random.Next(10, 400)
      });

      // Proteins
      ingredientNutrients.Add(new IngredientNutrient
      {
        IngredientId = ingredientId,
        NutrientId = 2,
        Amount = random.Next(0, 30)
      });

      // Add other nutrients randomly
      for (int nutrientId = 3; nutrientId <= 15; nutrientId++)
      {
        if (random.NextDouble() > 0.3) // 70% chance of having each nutrient
        {
          var amount = GetRealisticNutrientAmount(nutrientId, random);
          ingredientNutrients.Add(new IngredientNutrient
          {
            IngredientId = ingredientId,
            NutrientId = nutrientId,
            Amount = amount
          });
        }
      }
    }

    modelBuilder.Entity<IngredientNutrient>().HasData(ingredientNutrients);
  }

  private static Ingredient CreateIngredient(int id, string name, string description, DateTime baseDate)
  {
    return new Ingredient
    {
      Id = id,
      Name = name,
      Description = description,
      CreationDate = baseDate,
      UpdatedAt = baseDate
    };
  }

  private static decimal GetRealisticNutrientAmount(int nutrientId, Random random)
  {
    return nutrientId switch
    {
      3 => random.Next(0, 30), // Total Fat
      4 => random.Next(0, 10), // Saturated Fat
      5 => random.Next(0, 50), // Carbohydrates
      6 => random.Next(0, 15), // Fiber
      7 => random.Next(0, 20), // Sugar
      8 => random.Next(0, 1000), // Sodium
      9 => random.Next(50, 1000), // Potassium
      10 => random.Next(0, 5000), // Vitamin A
      11 => random.Next(0, 100), // Vitamin C
      12 => random.Next(0, 500), // Calcium
      13 => random.Next(0, 20), // Iron
      14 => random.Next(0, 400), // Vitamin D
      15 => random.Next(0, 6), // Vitamin B12
      _ => 0
    };
  }

  private static string GetVegetableName(int index)
  {
    var vegetables = new[]
    {
            "Carrot", "Broccoli", "Spinach", "Tomato", "Cucumber", "Bell Pepper", "Lettuce", "Onion",
            "Garlic", "Potato", "Sweet Potato", "Zucchini", "Eggplant", "Cauliflower", "Asparagus",
            "Green Beans", "Peas", "Corn", "Celery", "Mushroom", "Kale", "Brussels Sprouts",
            "Cabbage", "Artichoke", "Beetroot", "Radish", "Turnip", "Watercress", "Arugula",
            "Bok Choy", "Swiss Chard", "Collard Greens", "Okra", "Parsnip", "Rutabaga", "Shallot",
            "Leek", "Fennel", "Endive", "Radicchio"
        };
    return vegetables[index - 1];
  }

  private static string GetFruitName(int index)
  {
    var fruits = new[]
    {
            "Apple", "Banana", "Orange", "Grape", "Strawberry", "Blueberry", "Raspberry", "Blackberry",
            "Pear", "Peach", "Plum", "Cherry", "Lemon", "Lime", "Grapefruit", "Pineapple",
            "Mango", "Papaya", "Kiwi", "Watermelon", "Cantaloupe", "Honeydew", "Pomegranate",
            "Fig", "Date", "Apricot", "Nectarine", "Coconut", "Passion Fruit", "Dragon Fruit",
            "Guava", "Lychee", "Persimmon", "Mulberry", "Cranberry", "Gooseberry", "Tangerine",
            "Clementine", "Mandarin", "Kumquat"
        };
    return fruits[index - 1];
  }

  private static string GetProteinName(int index)
  {
    var proteins = new[]
    {
            "Chicken Breast", "Salmon", "Beef Steak", "Pork Chop", "Turkey", "Tuna", "Cod",
            "Shrimp", "Tofu", "Tempeh", "Seitan", "Black Beans", "Chickpeas", "Lentils",
            "Quinoa", "Almonds", "Walnuts", "Cashews", "Peanuts", "Pistachios", "Eggs",
            "Greek Yogurt", "Cottage Cheese", "Whey Protein", "Lamb", "Duck", "Tilapia",
            "Sardines", "Mackerel", "Halibut", "Mussels", "Crab", "Lobster", "Scallops",
            "Red Kidney Beans", "Navy Beans", "Pinto Beans", "Edamame", "Lima Beans", "Fava Beans"
        };
    return proteins[index - 1];
  }

  private static string GetGrainName(int index)
  {
    var grains = new[]
    {
            "Brown Rice", "White Rice", "Quinoa", "Oats", "Barley", "Buckwheat", "Millet",
            "Whole Wheat Bread", "White Bread", "Rye Bread", "Sourdough Bread", "Pasta",
            "Whole Wheat Pasta", "Couscous", "Bulgur", "Amaranth", "Sorghum", "Spelt",
            "Teff", "Kamut", "Corn Tortilla", "Flour Tortilla", "Pita Bread", "Bagel",
            "English Muffin", "Croissant", "Naan", "Focaccia", "Ciabatta", "Baguette",
            "Rice Noodles", "Soba Noodles", "Udon Noodles", "Rice Cake", "Crackers",
            "Cereal", "Granola", "Muesli", "Popcorn", "Cornmeal"
        };
    return grains[index - 1];
  }

  private static string GetDairyName(int index)
  {
    var dairy = new[]
    {
            "Whole Milk", "Low-fat Milk", "Skim Milk", "Heavy Cream", "Half and Half",
            "Butter", "Ghee", "Cheddar Cheese", "Mozzarella", "Parmesan", "Swiss Cheese",
            "Gouda", "Brie", "Camembert", "Blue Cheese", "Feta", "Cottage Cheese",
            "Ricotta", "Cream Cheese", "Sour Cream", "Greek Yogurt", "Regular Yogurt",
            "Kefir", "Buttermilk", "Whey", "Casein", "Provolone", "Manchego", "Gruyere",
            "Havarti", "Muenster", "Asiago", "Pecorino", "Mascarpone", "Burrata",
            "String Cheese", "Paneer", "Queso Fresco", "Halloumi", "Labneh"
        };
    return dairy[index - 1];
  }
}