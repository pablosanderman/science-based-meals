using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ScienceBasedMealsApi.Migrations
{
    /// <inheritdoc />
    public partial class AddIngredientAndNutrientSeeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ingredients_Units_UnitId",
                table: "Ingredients");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_ActivityLevels_ActivityLevelId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Genders_GenderId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Goals_GoalId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "ActivityLevels");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropTable(
                name: "Goals");

            migrationBuilder.DropIndex(
                name: "IX_Users_ActivityLevelId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_GenderId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_GoalId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Ingredients_UnitId",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "ActivityLevelId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Bio",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "GenderId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "GoalId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "HeightCm",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "WeightKg",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ConversionToBaseUnit",
                table: "Units");

            migrationBuilder.DropColumn(
                name: "UnitId",
                table: "Ingredients");

            migrationBuilder.RenameColumn(
                name: "UnitName",
                table: "Units",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Abbreviation",
                table: "Units",
                newName: "Description");

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "CreationDate", "Description", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Fresh vegetable", "Carrot", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 2, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Fresh vegetable", "Broccoli", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 3, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Fresh vegetable", "Spinach", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 4, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Fresh vegetable", "Tomato", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 5, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Fresh vegetable", "Cucumber", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 6, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Fresh vegetable", "Bell Pepper", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 7, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Fresh vegetable", "Lettuce", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 8, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Fresh vegetable", "Onion", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 9, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Fresh vegetable", "Garlic", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 10, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Fresh vegetable", "Potato", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 11, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Fresh vegetable", "Sweet Potato", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 12, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Fresh vegetable", "Zucchini", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 13, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Fresh vegetable", "Eggplant", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 14, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Fresh vegetable", "Cauliflower", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 15, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Fresh vegetable", "Asparagus", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 16, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Fresh vegetable", "Green Beans", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 17, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Fresh vegetable", "Peas", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 18, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Fresh vegetable", "Corn", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 19, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Fresh vegetable", "Celery", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 20, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Fresh vegetable", "Mushroom", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 21, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Fresh vegetable", "Kale", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 22, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Fresh vegetable", "Brussels Sprouts", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 23, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Fresh vegetable", "Cabbage", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 24, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Fresh vegetable", "Artichoke", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 25, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Fresh vegetable", "Beetroot", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 26, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Fresh vegetable", "Radish", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 27, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Fresh vegetable", "Turnip", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 28, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Fresh vegetable", "Watercress", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 29, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Fresh vegetable", "Arugula", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 30, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Fresh vegetable", "Bok Choy", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 31, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Fresh vegetable", "Swiss Chard", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 32, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Fresh vegetable", "Collard Greens", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 33, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Fresh vegetable", "Okra", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 34, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Fresh vegetable", "Parsnip", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 35, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Fresh vegetable", "Rutabaga", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 36, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Fresh vegetable", "Shallot", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 37, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Fresh vegetable", "Leek", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 38, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Fresh vegetable", "Fennel", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 39, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Fresh vegetable", "Endive", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 40, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Fresh vegetable", "Radicchio", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 41, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Fresh fruit", "Apple", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 42, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Fresh fruit", "Banana", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 43, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Fresh fruit", "Orange", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 44, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Fresh fruit", "Grape", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 45, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Fresh fruit", "Strawberry", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 46, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Fresh fruit", "Blueberry", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 47, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Fresh fruit", "Raspberry", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 48, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Fresh fruit", "Blackberry", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 49, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Fresh fruit", "Pear", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 50, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Fresh fruit", "Peach", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 51, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Fresh fruit", "Plum", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 52, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Fresh fruit", "Cherry", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 53, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Fresh fruit", "Lemon", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 54, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Fresh fruit", "Lime", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 55, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Fresh fruit", "Grapefruit", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 56, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Fresh fruit", "Pineapple", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 57, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Fresh fruit", "Mango", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 58, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Fresh fruit", "Papaya", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 59, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Fresh fruit", "Kiwi", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 60, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Fresh fruit", "Watermelon", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 61, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Fresh fruit", "Cantaloupe", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 62, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Fresh fruit", "Honeydew", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 63, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Fresh fruit", "Pomegranate", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 64, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Fresh fruit", "Fig", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 65, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Fresh fruit", "Date", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 66, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Fresh fruit", "Apricot", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 67, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Fresh fruit", "Nectarine", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 68, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Fresh fruit", "Coconut", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 69, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Fresh fruit", "Passion Fruit", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 70, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Fresh fruit", "Dragon Fruit", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 71, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Fresh fruit", "Guava", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 72, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Fresh fruit", "Lychee", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 73, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Fresh fruit", "Persimmon", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 74, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Fresh fruit", "Mulberry", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 75, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Fresh fruit", "Cranberry", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 76, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Fresh fruit", "Gooseberry", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 77, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Fresh fruit", "Tangerine", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 78, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Fresh fruit", "Clementine", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 79, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Fresh fruit", "Mandarin", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 80, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Fresh fruit", "Kumquat", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 81, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Protein source", "Chicken Breast", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 82, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Protein source", "Salmon", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 83, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Protein source", "Beef Steak", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 84, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Protein source", "Pork Chop", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 85, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Protein source", "Turkey", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 86, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Protein source", "Tuna", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 87, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Protein source", "Cod", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 88, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Protein source", "Shrimp", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 89, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Protein source", "Tofu", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 90, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Protein source", "Tempeh", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 91, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Protein source", "Seitan", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 92, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Protein source", "Black Beans", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 93, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Protein source", "Chickpeas", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 94, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Protein source", "Lentils", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 95, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Protein source", "Quinoa", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 96, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Protein source", "Almonds", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 97, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Protein source", "Walnuts", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 98, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Protein source", "Cashews", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 99, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Protein source", "Peanuts", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 100, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Protein source", "Pistachios", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 101, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Protein source", "Eggs", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 102, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Protein source", "Greek Yogurt", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 103, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Protein source", "Cottage Cheese", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 104, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Protein source", "Whey Protein", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 105, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Protein source", "Lamb", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 106, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Protein source", "Duck", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 107, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Protein source", "Tilapia", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 108, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Protein source", "Sardines", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 109, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Protein source", "Mackerel", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 110, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Protein source", "Halibut", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 111, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Protein source", "Mussels", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 112, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Protein source", "Crab", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 113, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Protein source", "Lobster", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 114, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Protein source", "Scallops", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 115, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Protein source", "Red Kidney Beans", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 116, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Protein source", "Navy Beans", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 117, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Protein source", "Pinto Beans", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 118, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Protein source", "Edamame", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 119, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Protein source", "Lima Beans", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 120, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Protein source", "Fava Beans", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 121, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Grain product", "Brown Rice", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 122, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Grain product", "White Rice", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 123, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Grain product", "Quinoa", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 124, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Grain product", "Oats", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 125, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Grain product", "Barley", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 126, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Grain product", "Buckwheat", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 127, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Grain product", "Millet", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 128, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Grain product", "Whole Wheat Bread", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 129, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Grain product", "White Bread", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 130, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Grain product", "Rye Bread", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 131, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Grain product", "Sourdough Bread", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 132, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Grain product", "Pasta", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 133, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Grain product", "Whole Wheat Pasta", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 134, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Grain product", "Couscous", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 135, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Grain product", "Bulgur", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 136, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Grain product", "Amaranth", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 137, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Grain product", "Sorghum", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 138, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Grain product", "Spelt", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 139, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Grain product", "Teff", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 140, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Grain product", "Kamut", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 141, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Grain product", "Corn Tortilla", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 142, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Grain product", "Flour Tortilla", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 143, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Grain product", "Pita Bread", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 144, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Grain product", "Bagel", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 145, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Grain product", "English Muffin", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 146, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Grain product", "Croissant", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 147, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Grain product", "Naan", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 148, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Grain product", "Focaccia", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 149, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Grain product", "Ciabatta", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 150, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Grain product", "Baguette", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 151, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Grain product", "Rice Noodles", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 152, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Grain product", "Soba Noodles", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 153, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Grain product", "Udon Noodles", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 154, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Grain product", "Rice Cake", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 155, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Grain product", "Crackers", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 156, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Grain product", "Cereal", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 157, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Grain product", "Granola", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 158, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Grain product", "Muesli", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 159, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Grain product", "Popcorn", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 160, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Grain product", "Cornmeal", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 161, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Dairy product", "Whole Milk", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 162, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Dairy product", "Low-fat Milk", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 163, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Dairy product", "Skim Milk", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 164, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Dairy product", "Heavy Cream", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 165, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Dairy product", "Half and Half", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 166, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Dairy product", "Butter", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 167, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Dairy product", "Ghee", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 168, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Dairy product", "Cheddar Cheese", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 169, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Dairy product", "Mozzarella", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 170, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Dairy product", "Parmesan", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 171, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Dairy product", "Swiss Cheese", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 172, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Dairy product", "Gouda", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 173, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Dairy product", "Brie", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 174, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Dairy product", "Camembert", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 175, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Dairy product", "Blue Cheese", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 176, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Dairy product", "Feta", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 177, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Dairy product", "Cottage Cheese", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 178, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Dairy product", "Ricotta", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 179, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Dairy product", "Cream Cheese", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 180, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Dairy product", "Sour Cream", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 181, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Dairy product", "Greek Yogurt", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 182, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Dairy product", "Regular Yogurt", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 183, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Dairy product", "Kefir", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 184, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Dairy product", "Buttermilk", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 185, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Dairy product", "Whey", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 186, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Dairy product", "Casein", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 187, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Dairy product", "Provolone", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 188, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Dairy product", "Manchego", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 189, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Dairy product", "Gruyere", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 190, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Dairy product", "Havarti", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 191, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Dairy product", "Muenster", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 192, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Dairy product", "Asiago", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 193, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Dairy product", "Pecorino", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 194, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Dairy product", "Mascarpone", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 195, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Dairy product", "Burrata", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 196, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Dairy product", "String Cheese", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 197, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Dairy product", "Paneer", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 198, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Dairy product", "Queso Fresco", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 199, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Dairy product", "Halloumi", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 200, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Dairy product", "Labneh", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "Units",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Grams", "g" },
                    { 2, "Milligrams", "mg" },
                    { 3, "Micrograms", "µg" },
                    { 4, "International Units", "IU" },
                    { 5, "Kilocalories", "kcal" }
                });

            migrationBuilder.InsertData(
                table: "Nutrients",
                columns: new[] { "Id", "DailyValue", "Name", "UnitId" },
                values: new object[,]
                {
                    { 1, 2000m, "Calories", 5 },
                    { 2, 50m, "Protein", 1 },
                    { 3, 65m, "Total Fat", 1 },
                    { 4, 20m, "Saturated Fat", 1 },
                    { 5, 300m, "Carbohydrates", 1 },
                    { 6, 25m, "Fiber", 1 },
                    { 7, 50m, "Sugar", 1 },
                    { 8, 2300m, "Sodium", 2 },
                    { 9, 3500m, "Potassium", 2 },
                    { 10, 5000m, "Vitamin A", 4 },
                    { 11, 60m, "Vitamin C", 2 },
                    { 12, 1000m, "Calcium", 2 },
                    { 13, 18m, "Iron", 2 },
                    { 14, 400m, "Vitamin D", 4 },
                    { 15, 6m, "Vitamin B12", 3 }
                });

            migrationBuilder.InsertData(
                table: "IngredientNutrients",
                columns: new[] { "IngredientId", "NutrientId", "Amount" },
                values: new object[,]
                {
                    { 1, 1, 393m },
                    { 1, 2, 27m },
                    { 1, 3, 24m },
                    { 1, 4, 0m },
                    { 1, 8, 909m },
                    { 1, 9, 229m },
                    { 1, 10, 393m },
                    { 1, 11, 56m },
                    { 1, 14, 63m },
                    { 2, 1, 314m },
                    { 2, 2, 0m },
                    { 2, 3, 19m },
                    { 2, 4, 8m },
                    { 2, 5, 7m },
                    { 2, 6, 12m },
                    { 2, 7, 1m },
                    { 2, 8, 93m },
                    { 2, 9, 245m },
                    { 2, 10, 3986m },
                    { 2, 11, 88m },
                    { 2, 12, 96m },
                    { 2, 13, 2m },
                    { 2, 15, 0m },
                    { 3, 1, 196m },
                    { 3, 2, 21m },
                    { 3, 5, 41m },
                    { 3, 6, 1m },
                    { 3, 7, 1m },
                    { 3, 9, 161m },
                    { 3, 10, 271m },
                    { 3, 13, 2m },
                    { 3, 14, 394m },
                    { 3, 15, 2m },
                    { 4, 1, 340m },
                    { 4, 2, 6m },
                    { 4, 5, 29m },
                    { 4, 7, 9m },
                    { 4, 8, 736m },
                    { 4, 10, 2205m },
                    { 4, 11, 21m },
                    { 4, 13, 19m },
                    { 5, 1, 129m },
                    { 5, 2, 13m },
                    { 5, 3, 7m },
                    { 5, 4, 1m },
                    { 5, 5, 18m },
                    { 5, 7, 3m },
                    { 5, 8, 338m },
                    { 5, 9, 811m },
                    { 5, 10, 2757m },
                    { 5, 11, 54m },
                    { 5, 12, 207m },
                    { 5, 13, 1m },
                    { 5, 14, 234m },
                    { 5, 15, 3m },
                    { 6, 1, 94m },
                    { 6, 2, 15m },
                    { 6, 3, 7m },
                    { 6, 5, 10m },
                    { 6, 6, 11m },
                    { 6, 10, 2726m },
                    { 6, 12, 393m },
                    { 6, 13, 9m },
                    { 7, 1, 25m },
                    { 7, 2, 20m },
                    { 7, 3, 6m },
                    { 7, 4, 6m },
                    { 7, 5, 32m },
                    { 7, 6, 6m },
                    { 7, 7, 16m },
                    { 7, 8, 483m },
                    { 7, 9, 239m },
                    { 7, 12, 63m },
                    { 7, 13, 0m },
                    { 7, 14, 215m },
                    { 7, 15, 0m },
                    { 8, 1, 380m },
                    { 8, 2, 4m },
                    { 8, 5, 4m },
                    { 8, 6, 6m },
                    { 8, 8, 170m },
                    { 8, 10, 367m },
                    { 8, 11, 88m },
                    { 8, 12, 381m },
                    { 8, 13, 5m },
                    { 8, 14, 24m },
                    { 8, 15, 1m },
                    { 9, 1, 208m },
                    { 9, 2, 12m },
                    { 9, 3, 29m },
                    { 9, 4, 0m },
                    { 9, 5, 7m },
                    { 9, 6, 4m },
                    { 9, 7, 11m },
                    { 9, 8, 95m },
                    { 9, 9, 603m },
                    { 9, 10, 534m },
                    { 9, 11, 0m },
                    { 9, 14, 289m },
                    { 9, 15, 5m },
                    { 10, 1, 252m },
                    { 10, 2, 17m },
                    { 10, 6, 11m },
                    { 10, 8, 422m },
                    { 10, 9, 560m },
                    { 10, 12, 6m },
                    { 10, 15, 5m },
                    { 11, 1, 199m },
                    { 11, 2, 9m },
                    { 11, 4, 9m },
                    { 11, 5, 37m },
                    { 11, 6, 2m },
                    { 11, 8, 975m },
                    { 11, 9, 513m },
                    { 11, 10, 3760m },
                    { 11, 11, 79m },
                    { 11, 13, 16m },
                    { 11, 14, 131m },
                    { 12, 1, 83m },
                    { 12, 2, 23m },
                    { 12, 5, 0m },
                    { 12, 8, 746m },
                    { 12, 9, 348m },
                    { 12, 10, 2240m },
                    { 12, 12, 67m },
                    { 12, 13, 18m },
                    { 12, 14, 233m },
                    { 12, 15, 1m },
                    { 13, 1, 244m },
                    { 13, 2, 23m },
                    { 13, 3, 1m },
                    { 13, 4, 2m },
                    { 13, 5, 2m },
                    { 13, 7, 19m },
                    { 13, 8, 183m },
                    { 13, 9, 627m },
                    { 13, 10, 699m },
                    { 13, 12, 298m },
                    { 13, 13, 1m },
                    { 13, 15, 3m },
                    { 14, 1, 278m },
                    { 14, 2, 16m },
                    { 14, 3, 15m },
                    { 14, 4, 8m },
                    { 14, 5, 38m },
                    { 14, 6, 6m },
                    { 14, 7, 14m },
                    { 14, 8, 707m },
                    { 14, 10, 3449m },
                    { 14, 12, 230m },
                    { 14, 13, 18m },
                    { 14, 14, 210m },
                    { 14, 15, 4m },
                    { 15, 1, 130m },
                    { 15, 2, 0m },
                    { 15, 3, 18m },
                    { 15, 4, 6m },
                    { 15, 5, 27m },
                    { 15, 6, 9m },
                    { 15, 7, 10m },
                    { 15, 8, 151m },
                    { 15, 9, 805m },
                    { 15, 10, 1605m },
                    { 15, 14, 203m },
                    { 15, 15, 5m },
                    { 16, 1, 346m },
                    { 16, 2, 22m },
                    { 16, 3, 18m },
                    { 16, 4, 8m },
                    { 16, 7, 10m },
                    { 16, 8, 949m },
                    { 16, 9, 914m },
                    { 16, 10, 1387m },
                    { 16, 11, 2m },
                    { 16, 12, 35m },
                    { 16, 14, 73m },
                    { 17, 1, 44m },
                    { 17, 2, 9m },
                    { 17, 3, 8m },
                    { 17, 5, 41m },
                    { 17, 6, 1m },
                    { 17, 7, 12m },
                    { 17, 8, 578m },
                    { 17, 9, 921m },
                    { 17, 10, 3124m },
                    { 17, 11, 13m },
                    { 17, 12, 392m },
                    { 17, 13, 13m },
                    { 17, 14, 219m },
                    { 17, 15, 4m },
                    { 18, 1, 187m },
                    { 18, 2, 3m },
                    { 18, 3, 22m },
                    { 18, 4, 5m },
                    { 18, 5, 26m },
                    { 18, 6, 5m },
                    { 18, 7, 18m },
                    { 18, 9, 110m },
                    { 18, 10, 1028m },
                    { 18, 12, 349m },
                    { 18, 13, 2m },
                    { 18, 14, 178m },
                    { 18, 15, 1m },
                    { 19, 1, 224m },
                    { 19, 2, 9m },
                    { 19, 4, 0m },
                    { 19, 5, 13m },
                    { 19, 6, 5m },
                    { 19, 7, 8m },
                    { 19, 8, 248m },
                    { 19, 9, 823m },
                    { 19, 10, 2328m },
                    { 19, 11, 74m },
                    { 19, 12, 55m },
                    { 19, 13, 14m },
                    { 19, 14, 189m },
                    { 20, 1, 327m },
                    { 20, 2, 6m },
                    { 20, 4, 5m },
                    { 20, 9, 330m },
                    { 20, 10, 1756m },
                    { 20, 12, 99m },
                    { 20, 13, 13m },
                    { 20, 14, 87m },
                    { 21, 1, 145m },
                    { 21, 2, 26m },
                    { 21, 4, 0m },
                    { 21, 5, 10m },
                    { 21, 7, 11m },
                    { 21, 10, 4664m },
                    { 21, 12, 11m },
                    { 21, 13, 4m },
                    { 21, 14, 73m },
                    { 21, 15, 2m },
                    { 22, 1, 46m },
                    { 22, 2, 19m },
                    { 22, 4, 8m },
                    { 22, 5, 30m },
                    { 22, 7, 5m },
                    { 22, 9, 379m },
                    { 22, 11, 49m },
                    { 22, 12, 414m },
                    { 22, 13, 8m },
                    { 22, 14, 18m },
                    { 22, 15, 2m },
                    { 23, 1, 89m },
                    { 23, 2, 18m },
                    { 23, 3, 9m },
                    { 23, 4, 1m },
                    { 23, 6, 14m },
                    { 23, 7, 0m },
                    { 23, 8, 952m },
                    { 23, 10, 1540m },
                    { 23, 11, 53m },
                    { 23, 12, 451m },
                    { 23, 13, 9m },
                    { 23, 14, 141m },
                    { 23, 15, 2m },
                    { 24, 1, 292m },
                    { 24, 2, 3m },
                    { 24, 3, 29m },
                    { 24, 4, 0m },
                    { 24, 5, 32m },
                    { 24, 6, 3m },
                    { 24, 8, 220m },
                    { 24, 9, 995m },
                    { 24, 11, 82m },
                    { 24, 13, 10m },
                    { 24, 14, 195m },
                    { 24, 15, 2m },
                    { 25, 1, 136m },
                    { 25, 2, 11m },
                    { 25, 3, 21m },
                    { 25, 4, 9m },
                    { 25, 5, 48m },
                    { 25, 6, 6m },
                    { 25, 8, 993m },
                    { 25, 10, 87m },
                    { 25, 11, 69m },
                    { 25, 14, 125m },
                    { 26, 1, 363m },
                    { 26, 2, 13m },
                    { 26, 3, 25m },
                    { 26, 5, 39m },
                    { 26, 6, 9m },
                    { 26, 7, 11m },
                    { 26, 9, 260m },
                    { 26, 10, 3336m },
                    { 26, 11, 95m },
                    { 26, 12, 359m },
                    { 26, 13, 17m },
                    { 26, 14, 200m },
                    { 26, 15, 1m },
                    { 27, 1, 276m },
                    { 27, 2, 7m },
                    { 27, 3, 11m },
                    { 27, 4, 7m },
                    { 27, 7, 5m },
                    { 27, 8, 69m },
                    { 27, 10, 3551m },
                    { 27, 12, 344m },
                    { 27, 13, 16m },
                    { 27, 15, 2m },
                    { 28, 1, 20m },
                    { 28, 2, 23m },
                    { 28, 4, 5m },
                    { 28, 5, 2m },
                    { 28, 6, 7m },
                    { 28, 8, 938m },
                    { 28, 9, 618m },
                    { 28, 11, 85m },
                    { 28, 13, 7m },
                    { 28, 14, 361m },
                    { 29, 1, 329m },
                    { 29, 2, 29m },
                    { 29, 4, 3m },
                    { 29, 7, 18m },
                    { 29, 8, 864m },
                    { 29, 9, 628m },
                    { 29, 10, 1839m },
                    { 29, 11, 76m },
                    { 29, 12, 301m },
                    { 30, 1, 173m },
                    { 30, 2, 4m },
                    { 30, 3, 7m },
                    { 30, 4, 5m },
                    { 30, 5, 35m },
                    { 30, 6, 10m },
                    { 30, 8, 276m },
                    { 30, 9, 606m },
                    { 30, 10, 3317m },
                    { 30, 11, 39m },
                    { 30, 13, 1m },
                    { 30, 14, 363m },
                    { 30, 15, 5m },
                    { 31, 1, 199m },
                    { 31, 2, 22m },
                    { 31, 3, 16m },
                    { 31, 5, 11m },
                    { 31, 6, 8m },
                    { 31, 7, 4m },
                    { 31, 9, 537m },
                    { 31, 12, 77m },
                    { 31, 13, 1m },
                    { 31, 15, 4m },
                    { 32, 1, 95m },
                    { 32, 2, 4m },
                    { 32, 4, 9m },
                    { 32, 6, 7m },
                    { 32, 7, 11m },
                    { 32, 8, 81m },
                    { 32, 9, 901m },
                    { 32, 10, 3232m },
                    { 32, 11, 31m },
                    { 32, 12, 409m },
                    { 32, 13, 5m },
                    { 32, 14, 323m },
                    { 32, 15, 4m },
                    { 33, 1, 306m },
                    { 33, 2, 17m },
                    { 33, 3, 10m },
                    { 33, 4, 8m },
                    { 33, 5, 46m },
                    { 33, 6, 6m },
                    { 33, 8, 305m },
                    { 33, 9, 229m },
                    { 33, 10, 3066m },
                    { 33, 11, 30m },
                    { 33, 12, 187m },
                    { 33, 13, 11m },
                    { 33, 14, 24m },
                    { 33, 15, 2m },
                    { 34, 1, 76m },
                    { 34, 2, 2m },
                    { 34, 3, 18m },
                    { 34, 7, 15m },
                    { 34, 8, 296m },
                    { 34, 10, 2936m },
                    { 34, 11, 30m },
                    { 34, 12, 318m },
                    { 34, 13, 0m },
                    { 34, 15, 2m },
                    { 35, 1, 274m },
                    { 35, 2, 29m },
                    { 35, 3, 13m },
                    { 35, 4, 4m },
                    { 35, 8, 362m },
                    { 35, 9, 841m },
                    { 35, 10, 3912m },
                    { 35, 11, 69m },
                    { 35, 13, 8m },
                    { 35, 14, 126m },
                    { 35, 15, 4m },
                    { 36, 1, 339m },
                    { 36, 2, 11m },
                    { 36, 5, 13m },
                    { 36, 6, 3m },
                    { 36, 7, 14m },
                    { 36, 9, 754m },
                    { 36, 10, 3527m },
                    { 36, 12, 461m },
                    { 37, 1, 113m },
                    { 37, 2, 4m },
                    { 37, 3, 20m },
                    { 37, 4, 0m },
                    { 37, 5, 11m },
                    { 37, 7, 7m },
                    { 37, 8, 813m },
                    { 37, 9, 88m },
                    { 37, 10, 4382m },
                    { 37, 15, 0m },
                    { 38, 1, 172m },
                    { 38, 2, 4m },
                    { 38, 5, 48m },
                    { 38, 6, 7m },
                    { 38, 7, 6m },
                    { 38, 8, 579m },
                    { 38, 10, 2210m },
                    { 38, 11, 17m },
                    { 38, 12, 2m },
                    { 38, 13, 16m },
                    { 38, 14, 64m },
                    { 38, 15, 5m },
                    { 39, 1, 269m },
                    { 39, 2, 19m },
                    { 39, 3, 23m },
                    { 39, 7, 1m },
                    { 39, 9, 861m },
                    { 39, 10, 1785m },
                    { 39, 12, 209m },
                    { 39, 15, 0m },
                    { 40, 1, 329m },
                    { 40, 2, 29m },
                    { 40, 3, 4m },
                    { 40, 4, 1m },
                    { 40, 6, 4m },
                    { 40, 7, 19m },
                    { 40, 10, 1666m },
                    { 40, 11, 73m },
                    { 40, 14, 38m },
                    { 41, 1, 78m },
                    { 41, 2, 27m },
                    { 41, 5, 37m },
                    { 41, 6, 5m },
                    { 41, 7, 19m },
                    { 41, 8, 940m },
                    { 41, 9, 667m },
                    { 41, 10, 3095m },
                    { 41, 12, 2m },
                    { 41, 14, 277m },
                    { 41, 15, 4m },
                    { 42, 1, 321m },
                    { 42, 2, 16m },
                    { 42, 3, 25m },
                    { 42, 4, 7m },
                    { 42, 7, 13m },
                    { 42, 8, 529m },
                    { 42, 10, 2908m },
                    { 42, 11, 71m },
                    { 42, 12, 350m },
                    { 42, 13, 10m },
                    { 42, 15, 4m },
                    { 43, 1, 115m },
                    { 43, 2, 3m },
                    { 43, 5, 3m },
                    { 43, 6, 7m },
                    { 43, 7, 7m },
                    { 43, 8, 14m },
                    { 43, 9, 897m },
                    { 43, 10, 290m },
                    { 43, 11, 49m },
                    { 43, 14, 374m },
                    { 43, 15, 3m },
                    { 44, 1, 172m },
                    { 44, 2, 18m },
                    { 44, 3, 25m },
                    { 44, 4, 5m },
                    { 44, 6, 8m },
                    { 44, 8, 565m },
                    { 44, 9, 865m },
                    { 44, 10, 4277m },
                    { 44, 12, 88m },
                    { 44, 13, 3m },
                    { 44, 14, 228m },
                    { 44, 15, 1m },
                    { 45, 1, 260m },
                    { 45, 2, 0m },
                    { 45, 5, 42m },
                    { 45, 6, 7m },
                    { 45, 7, 14m },
                    { 45, 8, 769m },
                    { 45, 9, 514m },
                    { 45, 10, 777m },
                    { 45, 11, 42m },
                    { 45, 12, 157m },
                    { 45, 14, 45m },
                    { 45, 15, 0m },
                    { 46, 1, 377m },
                    { 46, 2, 15m },
                    { 46, 3, 29m },
                    { 46, 4, 8m },
                    { 46, 6, 9m },
                    { 46, 7, 10m },
                    { 46, 9, 823m },
                    { 46, 10, 1213m },
                    { 47, 1, 275m },
                    { 47, 2, 25m },
                    { 47, 3, 14m },
                    { 47, 4, 1m },
                    { 47, 6, 1m },
                    { 47, 8, 288m },
                    { 47, 10, 1640m },
                    { 47, 11, 53m },
                    { 47, 13, 12m },
                    { 47, 15, 0m },
                    { 48, 1, 111m },
                    { 48, 2, 29m },
                    { 48, 3, 18m },
                    { 48, 8, 690m },
                    { 48, 11, 37m },
                    { 48, 12, 8m },
                    { 48, 13, 0m },
                    { 48, 14, 216m },
                    { 49, 1, 253m },
                    { 49, 2, 26m },
                    { 49, 3, 29m },
                    { 49, 5, 25m },
                    { 49, 6, 3m },
                    { 49, 7, 15m },
                    { 49, 8, 697m },
                    { 49, 10, 4369m },
                    { 49, 11, 85m },
                    { 49, 12, 0m },
                    { 49, 13, 18m },
                    { 49, 14, 394m },
                    { 49, 15, 3m },
                    { 50, 1, 87m },
                    { 50, 2, 1m },
                    { 50, 5, 16m },
                    { 50, 6, 0m },
                    { 50, 7, 1m },
                    { 50, 9, 122m },
                    { 50, 10, 2802m },
                    { 50, 11, 76m },
                    { 50, 14, 391m },
                    { 51, 1, 397m },
                    { 51, 2, 4m },
                    { 51, 5, 27m },
                    { 51, 7, 5m },
                    { 51, 8, 410m },
                    { 51, 9, 495m },
                    { 51, 10, 3836m },
                    { 51, 12, 233m },
                    { 51, 13, 13m },
                    { 51, 14, 173m },
                    { 51, 15, 5m },
                    { 52, 1, 314m },
                    { 52, 2, 1m },
                    { 52, 3, 17m },
                    { 52, 5, 35m },
                    { 52, 7, 18m },
                    { 52, 10, 2048m },
                    { 52, 11, 86m },
                    { 52, 12, 463m },
                    { 52, 13, 17m },
                    { 52, 15, 5m },
                    { 53, 1, 40m },
                    { 53, 2, 18m },
                    { 53, 3, 13m },
                    { 53, 4, 1m },
                    { 53, 5, 38m },
                    { 53, 6, 6m },
                    { 53, 8, 492m },
                    { 53, 10, 2792m },
                    { 53, 11, 60m },
                    { 53, 12, 375m },
                    { 53, 13, 8m },
                    { 53, 14, 18m },
                    { 53, 15, 3m },
                    { 54, 1, 191m },
                    { 54, 2, 24m },
                    { 54, 3, 19m },
                    { 54, 4, 6m },
                    { 54, 7, 19m },
                    { 54, 8, 897m },
                    { 54, 9, 853m },
                    { 54, 10, 919m },
                    { 54, 11, 57m },
                    { 54, 12, 2m },
                    { 54, 13, 15m },
                    { 54, 15, 4m },
                    { 55, 1, 104m },
                    { 55, 2, 25m },
                    { 55, 3, 12m },
                    { 55, 4, 8m },
                    { 55, 5, 0m },
                    { 55, 7, 10m },
                    { 55, 9, 611m },
                    { 55, 10, 1377m },
                    { 55, 11, 73m },
                    { 55, 12, 65m },
                    { 55, 14, 208m },
                    { 55, 15, 2m },
                    { 56, 1, 382m },
                    { 56, 2, 5m },
                    { 56, 3, 12m },
                    { 56, 4, 6m },
                    { 56, 5, 9m },
                    { 56, 6, 9m },
                    { 56, 7, 4m },
                    { 56, 8, 725m },
                    { 56, 10, 4419m },
                    { 56, 11, 11m },
                    { 56, 12, 490m },
                    { 56, 13, 19m },
                    { 56, 15, 5m },
                    { 57, 1, 21m },
                    { 57, 2, 19m },
                    { 57, 4, 5m },
                    { 57, 5, 25m },
                    { 57, 7, 13m },
                    { 57, 8, 597m },
                    { 57, 9, 81m },
                    { 57, 10, 47m },
                    { 57, 12, 394m },
                    { 57, 14, 4m },
                    { 57, 15, 2m },
                    { 58, 1, 82m },
                    { 58, 2, 28m },
                    { 58, 3, 15m },
                    { 58, 4, 3m },
                    { 58, 7, 8m },
                    { 58, 8, 872m },
                    { 58, 9, 154m },
                    { 58, 11, 71m },
                    { 58, 12, 21m },
                    { 58, 13, 8m },
                    { 58, 15, 0m },
                    { 59, 1, 353m },
                    { 59, 2, 29m },
                    { 59, 3, 0m },
                    { 59, 4, 6m },
                    { 59, 8, 554m },
                    { 59, 9, 925m },
                    { 59, 10, 3611m },
                    { 59, 11, 49m },
                    { 59, 13, 6m },
                    { 59, 14, 41m },
                    { 60, 1, 377m },
                    { 60, 2, 27m },
                    { 60, 4, 1m },
                    { 60, 5, 2m },
                    { 60, 6, 13m },
                    { 60, 7, 6m },
                    { 60, 8, 383m },
                    { 60, 9, 226m },
                    { 60, 10, 15m },
                    { 60, 12, 353m },
                    { 60, 14, 197m },
                    { 60, 15, 4m },
                    { 61, 1, 353m },
                    { 61, 2, 22m },
                    { 61, 3, 9m },
                    { 61, 4, 6m },
                    { 61, 5, 38m },
                    { 61, 6, 8m },
                    { 61, 9, 131m },
                    { 61, 12, 327m },
                    { 61, 13, 11m },
                    { 61, 14, 135m },
                    { 61, 15, 1m },
                    { 62, 1, 81m },
                    { 62, 2, 27m },
                    { 62, 4, 3m },
                    { 62, 5, 19m },
                    { 62, 6, 10m },
                    { 62, 7, 4m },
                    { 62, 10, 2612m },
                    { 62, 11, 61m },
                    { 62, 12, 233m },
                    { 62, 15, 3m },
                    { 63, 1, 72m },
                    { 63, 2, 18m },
                    { 63, 3, 5m },
                    { 63, 4, 8m },
                    { 63, 5, 19m },
                    { 63, 6, 4m },
                    { 63, 7, 2m },
                    { 63, 8, 529m },
                    { 63, 10, 4753m },
                    { 63, 12, 140m },
                    { 63, 13, 17m },
                    { 63, 14, 8m },
                    { 64, 1, 61m },
                    { 64, 2, 7m },
                    { 64, 3, 13m },
                    { 64, 4, 2m },
                    { 64, 8, 104m },
                    { 64, 9, 789m },
                    { 64, 10, 2617m },
                    { 64, 11, 20m },
                    { 64, 12, 482m },
                    { 64, 13, 10m },
                    { 64, 15, 3m },
                    { 65, 1, 202m },
                    { 65, 2, 15m },
                    { 65, 4, 6m },
                    { 65, 5, 15m },
                    { 65, 6, 8m },
                    { 65, 7, 15m },
                    { 65, 8, 996m },
                    { 65, 9, 686m },
                    { 65, 11, 84m },
                    { 65, 13, 18m },
                    { 65, 14, 68m },
                    { 65, 15, 0m },
                    { 66, 1, 215m },
                    { 66, 2, 16m },
                    { 66, 4, 5m },
                    { 66, 5, 3m },
                    { 66, 6, 5m },
                    { 66, 7, 7m },
                    { 66, 9, 661m },
                    { 66, 10, 3156m },
                    { 66, 11, 23m },
                    { 66, 12, 358m },
                    { 66, 13, 15m },
                    { 67, 1, 364m },
                    { 67, 2, 0m },
                    { 67, 3, 25m },
                    { 67, 5, 45m },
                    { 67, 6, 5m },
                    { 67, 9, 179m },
                    { 67, 10, 4m },
                    { 67, 12, 115m },
                    { 67, 13, 19m },
                    { 67, 14, 359m },
                    { 67, 15, 1m },
                    { 68, 1, 341m },
                    { 68, 2, 28m },
                    { 68, 3, 10m },
                    { 68, 4, 0m },
                    { 68, 6, 4m },
                    { 68, 8, 554m },
                    { 68, 12, 26m },
                    { 68, 14, 214m },
                    { 68, 15, 0m },
                    { 69, 1, 203m },
                    { 69, 2, 11m },
                    { 69, 4, 0m },
                    { 69, 5, 6m },
                    { 69, 6, 10m },
                    { 69, 8, 473m },
                    { 69, 9, 307m },
                    { 69, 11, 1m },
                    { 69, 12, 491m },
                    { 69, 13, 1m },
                    { 69, 14, 398m },
                    { 69, 15, 1m },
                    { 70, 1, 186m },
                    { 70, 2, 1m },
                    { 70, 3, 27m },
                    { 70, 4, 0m },
                    { 70, 6, 12m },
                    { 70, 7, 4m },
                    { 70, 9, 974m },
                    { 70, 10, 3150m },
                    { 70, 11, 44m },
                    { 70, 12, 86m },
                    { 70, 13, 4m },
                    { 70, 14, 227m },
                    { 70, 15, 0m },
                    { 71, 1, 202m },
                    { 71, 2, 16m },
                    { 71, 4, 5m },
                    { 71, 5, 39m },
                    { 71, 6, 8m },
                    { 71, 7, 3m },
                    { 71, 8, 401m },
                    { 71, 9, 320m },
                    { 71, 10, 797m },
                    { 71, 11, 90m },
                    { 71, 12, 152m },
                    { 71, 13, 6m },
                    { 71, 14, 45m },
                    { 71, 15, 0m },
                    { 72, 1, 116m },
                    { 72, 2, 18m },
                    { 72, 5, 21m },
                    { 72, 6, 8m },
                    { 72, 7, 9m },
                    { 72, 8, 957m },
                    { 72, 9, 358m },
                    { 72, 11, 4m },
                    { 72, 12, 273m },
                    { 72, 14, 355m },
                    { 72, 15, 0m },
                    { 73, 1, 51m },
                    { 73, 2, 19m },
                    { 73, 4, 1m },
                    { 73, 6, 12m },
                    { 73, 7, 6m },
                    { 73, 8, 848m },
                    { 73, 9, 484m },
                    { 73, 10, 4912m },
                    { 73, 12, 370m },
                    { 73, 13, 5m },
                    { 73, 14, 33m },
                    { 74, 1, 30m },
                    { 74, 2, 28m },
                    { 74, 3, 8m },
                    { 74, 4, 4m },
                    { 74, 6, 12m },
                    { 74, 9, 447m },
                    { 74, 10, 2226m },
                    { 74, 11, 95m },
                    { 74, 13, 10m },
                    { 74, 14, 162m },
                    { 75, 1, 237m },
                    { 75, 2, 18m },
                    { 75, 3, 28m },
                    { 75, 4, 1m },
                    { 75, 5, 40m },
                    { 75, 7, 17m },
                    { 75, 8, 174m },
                    { 75, 9, 266m },
                    { 75, 11, 24m },
                    { 75, 15, 0m },
                    { 76, 1, 230m },
                    { 76, 2, 14m },
                    { 76, 3, 12m },
                    { 76, 4, 1m },
                    { 76, 5, 29m },
                    { 76, 6, 9m },
                    { 76, 7, 14m },
                    { 76, 8, 2m },
                    { 76, 9, 470m },
                    { 76, 11, 31m },
                    { 76, 12, 63m },
                    { 76, 13, 19m },
                    { 76, 15, 4m },
                    { 77, 1, 324m },
                    { 77, 2, 15m },
                    { 77, 4, 4m },
                    { 77, 5, 7m },
                    { 77, 6, 0m },
                    { 77, 7, 14m },
                    { 77, 8, 16m },
                    { 77, 9, 429m },
                    { 77, 10, 2689m },
                    { 77, 11, 25m },
                    { 77, 13, 5m },
                    { 77, 14, 320m },
                    { 77, 15, 3m },
                    { 78, 1, 367m },
                    { 78, 2, 19m },
                    { 78, 3, 0m },
                    { 78, 4, 6m },
                    { 78, 5, 33m },
                    { 78, 6, 5m },
                    { 78, 7, 12m },
                    { 78, 10, 950m },
                    { 78, 13, 9m },
                    { 78, 14, 279m },
                    { 78, 15, 0m },
                    { 79, 1, 14m },
                    { 79, 2, 29m },
                    { 79, 6, 8m },
                    { 79, 7, 15m },
                    { 79, 8, 886m },
                    { 79, 9, 511m },
                    { 79, 10, 4612m },
                    { 79, 12, 175m },
                    { 79, 15, 5m },
                    { 80, 1, 302m },
                    { 80, 2, 3m },
                    { 80, 3, 11m },
                    { 80, 5, 3m },
                    { 80, 6, 2m },
                    { 80, 9, 50m },
                    { 80, 10, 3114m },
                    { 80, 11, 49m },
                    { 80, 12, 389m },
                    { 80, 13, 16m },
                    { 80, 14, 93m },
                    { 81, 1, 284m },
                    { 81, 2, 0m },
                    { 81, 4, 7m },
                    { 81, 6, 4m },
                    { 81, 7, 2m },
                    { 81, 9, 655m },
                    { 81, 10, 1477m },
                    { 81, 11, 37m },
                    { 81, 12, 335m },
                    { 81, 13, 4m },
                    { 81, 14, 394m },
                    { 81, 15, 2m },
                    { 82, 1, 27m },
                    { 82, 2, 25m },
                    { 82, 3, 7m },
                    { 82, 4, 0m },
                    { 82, 5, 44m },
                    { 82, 6, 9m },
                    { 82, 8, 430m },
                    { 82, 9, 136m },
                    { 82, 10, 4819m },
                    { 82, 11, 88m },
                    { 82, 12, 367m },
                    { 82, 14, 218m },
                    { 83, 1, 203m },
                    { 83, 2, 12m },
                    { 83, 3, 16m },
                    { 83, 4, 0m },
                    { 83, 6, 2m },
                    { 83, 7, 4m },
                    { 83, 10, 336m },
                    { 83, 11, 98m },
                    { 84, 1, 378m },
                    { 84, 2, 22m },
                    { 84, 3, 27m },
                    { 84, 8, 960m },
                    { 84, 10, 1135m },
                    { 84, 11, 61m },
                    { 84, 12, 167m },
                    { 84, 13, 11m },
                    { 84, 15, 1m },
                    { 85, 1, 387m },
                    { 85, 2, 26m },
                    { 85, 3, 27m },
                    { 85, 4, 8m },
                    { 85, 5, 37m },
                    { 85, 6, 8m },
                    { 85, 7, 19m },
                    { 85, 8, 678m },
                    { 85, 10, 3104m },
                    { 85, 11, 92m },
                    { 85, 12, 238m },
                    { 85, 13, 0m },
                    { 85, 15, 2m },
                    { 86, 1, 185m },
                    { 86, 2, 8m },
                    { 86, 3, 12m },
                    { 86, 4, 8m },
                    { 86, 6, 11m },
                    { 86, 7, 5m },
                    { 86, 8, 456m },
                    { 86, 10, 4861m },
                    { 86, 11, 61m },
                    { 86, 12, 133m },
                    { 86, 13, 18m },
                    { 86, 14, 278m },
                    { 87, 1, 284m },
                    { 87, 2, 8m },
                    { 87, 4, 2m },
                    { 87, 5, 19m },
                    { 87, 7, 7m },
                    { 87, 10, 4934m },
                    { 87, 11, 72m },
                    { 87, 12, 445m },
                    { 87, 13, 7m },
                    { 87, 15, 3m },
                    { 88, 1, 103m },
                    { 88, 2, 15m },
                    { 88, 3, 12m },
                    { 88, 4, 5m },
                    { 88, 5, 25m },
                    { 88, 6, 14m },
                    { 88, 7, 17m },
                    { 88, 8, 175m },
                    { 88, 9, 568m },
                    { 88, 10, 4417m },
                    { 88, 13, 7m },
                    { 88, 14, 155m },
                    { 88, 15, 4m },
                    { 89, 1, 220m },
                    { 89, 2, 27m },
                    { 89, 4, 3m },
                    { 89, 5, 14m },
                    { 89, 6, 12m },
                    { 89, 8, 411m },
                    { 89, 9, 531m },
                    { 89, 10, 4277m },
                    { 90, 1, 225m },
                    { 90, 2, 26m },
                    { 90, 3, 18m },
                    { 90, 4, 0m },
                    { 90, 5, 35m },
                    { 90, 6, 9m },
                    { 90, 7, 15m },
                    { 90, 10, 2312m },
                    { 90, 11, 62m },
                    { 90, 12, 287m },
                    { 90, 13, 7m },
                    { 90, 14, 25m },
                    { 90, 15, 2m },
                    { 91, 1, 306m },
                    { 91, 2, 7m },
                    { 91, 5, 7m },
                    { 91, 6, 9m },
                    { 91, 7, 0m },
                    { 91, 8, 354m },
                    { 91, 9, 774m },
                    { 91, 10, 4650m },
                    { 91, 11, 62m },
                    { 91, 13, 5m },
                    { 91, 14, 47m },
                    { 91, 15, 2m },
                    { 92, 1, 206m },
                    { 92, 2, 19m },
                    { 92, 3, 5m },
                    { 92, 11, 75m },
                    { 92, 12, 105m },
                    { 92, 14, 16m },
                    { 92, 15, 4m },
                    { 93, 1, 227m },
                    { 93, 2, 23m },
                    { 93, 3, 19m },
                    { 93, 4, 3m },
                    { 93, 6, 12m },
                    { 93, 10, 3551m },
                    { 93, 12, 474m },
                    { 93, 13, 15m },
                    { 93, 14, 168m },
                    { 94, 1, 312m },
                    { 94, 2, 15m },
                    { 94, 3, 8m },
                    { 94, 5, 44m },
                    { 94, 6, 9m },
                    { 94, 7, 9m },
                    { 94, 8, 825m },
                    { 94, 9, 849m },
                    { 94, 10, 977m },
                    { 94, 11, 12m },
                    { 94, 12, 160m },
                    { 94, 13, 19m },
                    { 94, 14, 391m },
                    { 95, 1, 256m },
                    { 95, 2, 21m },
                    { 95, 3, 5m },
                    { 95, 5, 16m },
                    { 95, 6, 0m },
                    { 95, 7, 16m },
                    { 95, 8, 183m },
                    { 95, 9, 102m },
                    { 95, 10, 2489m },
                    { 95, 11, 67m },
                    { 95, 13, 10m },
                    { 95, 14, 19m },
                    { 96, 1, 396m },
                    { 96, 2, 21m },
                    { 96, 4, 8m },
                    { 96, 5, 41m },
                    { 96, 10, 2362m },
                    { 96, 12, 146m },
                    { 96, 13, 14m },
                    { 96, 14, 23m },
                    { 96, 15, 3m },
                    { 97, 1, 324m },
                    { 97, 2, 8m },
                    { 97, 3, 12m },
                    { 97, 5, 46m },
                    { 97, 10, 1288m },
                    { 97, 13, 3m },
                    { 97, 14, 3m },
                    { 97, 15, 0m },
                    { 98, 1, 85m },
                    { 98, 2, 25m },
                    { 98, 3, 0m },
                    { 98, 4, 0m },
                    { 98, 5, 20m },
                    { 98, 6, 1m },
                    { 98, 7, 14m },
                    { 98, 8, 902m },
                    { 98, 9, 120m },
                    { 98, 10, 2009m },
                    { 98, 11, 36m },
                    { 98, 15, 3m },
                    { 99, 1, 373m },
                    { 99, 2, 15m },
                    { 99, 4, 5m },
                    { 99, 5, 2m },
                    { 99, 7, 12m },
                    { 99, 8, 256m },
                    { 99, 9, 507m },
                    { 99, 12, 160m },
                    { 99, 13, 6m },
                    { 99, 15, 1m },
                    { 100, 1, 175m },
                    { 100, 2, 12m },
                    { 100, 3, 11m },
                    { 100, 4, 0m },
                    { 100, 7, 17m },
                    { 100, 8, 718m },
                    { 100, 9, 715m },
                    { 100, 10, 1137m },
                    { 100, 11, 93m },
                    { 100, 12, 388m },
                    { 100, 14, 326m },
                    { 101, 1, 368m },
                    { 101, 2, 8m },
                    { 101, 5, 11m },
                    { 101, 6, 5m },
                    { 101, 9, 595m },
                    { 101, 10, 2014m },
                    { 101, 11, 4m },
                    { 101, 12, 212m },
                    { 101, 13, 7m },
                    { 101, 14, 305m },
                    { 101, 15, 2m },
                    { 102, 1, 129m },
                    { 102, 2, 2m },
                    { 102, 3, 11m },
                    { 102, 4, 1m },
                    { 102, 5, 0m },
                    { 102, 6, 10m },
                    { 102, 7, 3m },
                    { 102, 8, 750m },
                    { 102, 9, 497m },
                    { 102, 10, 801m },
                    { 102, 11, 24m },
                    { 102, 13, 7m },
                    { 102, 14, 144m },
                    { 102, 15, 1m },
                    { 103, 1, 347m },
                    { 103, 2, 21m },
                    { 103, 3, 3m },
                    { 103, 5, 33m },
                    { 103, 6, 8m },
                    { 103, 7, 19m },
                    { 103, 8, 944m },
                    { 103, 9, 630m },
                    { 103, 10, 558m },
                    { 103, 11, 37m },
                    { 103, 13, 18m },
                    { 103, 15, 4m },
                    { 104, 1, 46m },
                    { 104, 2, 14m },
                    { 104, 3, 13m },
                    { 104, 4, 6m },
                    { 104, 6, 13m },
                    { 104, 10, 1444m },
                    { 104, 11, 19m },
                    { 104, 12, 454m },
                    { 104, 13, 10m },
                    { 104, 14, 289m },
                    { 104, 15, 2m },
                    { 105, 1, 352m },
                    { 105, 2, 8m },
                    { 105, 3, 29m },
                    { 105, 4, 3m },
                    { 105, 5, 24m },
                    { 105, 6, 5m },
                    { 105, 10, 4481m },
                    { 105, 12, 426m },
                    { 105, 14, 124m },
                    { 105, 15, 2m },
                    { 106, 1, 270m },
                    { 106, 2, 22m },
                    { 106, 3, 1m },
                    { 106, 5, 17m },
                    { 106, 6, 5m },
                    { 106, 7, 18m },
                    { 106, 8, 412m },
                    { 106, 9, 74m },
                    { 106, 10, 2791m },
                    { 106, 12, 296m },
                    { 106, 15, 5m },
                    { 107, 1, 122m },
                    { 107, 2, 0m },
                    { 107, 3, 15m },
                    { 107, 4, 6m },
                    { 107, 5, 7m },
                    { 107, 7, 6m },
                    { 107, 9, 350m },
                    { 107, 10, 229m },
                    { 107, 12, 346m },
                    { 107, 13, 6m },
                    { 107, 14, 193m },
                    { 107, 15, 5m },
                    { 108, 1, 144m },
                    { 108, 2, 14m },
                    { 108, 4, 2m },
                    { 108, 6, 3m },
                    { 108, 8, 0m },
                    { 108, 9, 832m },
                    { 108, 10, 3379m },
                    { 108, 12, 259m },
                    { 108, 13, 5m },
                    { 108, 14, 21m },
                    { 109, 1, 82m },
                    { 109, 2, 23m },
                    { 109, 3, 8m },
                    { 109, 4, 0m },
                    { 109, 5, 17m },
                    { 109, 6, 3m },
                    { 109, 7, 3m },
                    { 109, 9, 674m },
                    { 109, 10, 2717m },
                    { 109, 11, 1m },
                    { 109, 12, 282m },
                    { 109, 13, 6m },
                    { 109, 14, 46m },
                    { 110, 1, 205m },
                    { 110, 2, 15m },
                    { 110, 3, 25m },
                    { 110, 9, 854m },
                    { 110, 10, 4552m },
                    { 110, 12, 201m },
                    { 110, 13, 9m },
                    { 110, 15, 2m },
                    { 111, 1, 254m },
                    { 111, 2, 4m },
                    { 111, 3, 2m },
                    { 111, 4, 7m },
                    { 111, 5, 33m },
                    { 111, 7, 0m },
                    { 111, 9, 542m },
                    { 111, 11, 67m },
                    { 111, 13, 17m },
                    { 111, 14, 153m },
                    { 111, 15, 5m },
                    { 112, 1, 235m },
                    { 112, 2, 29m },
                    { 112, 3, 29m },
                    { 112, 5, 42m },
                    { 112, 7, 11m },
                    { 112, 8, 387m },
                    { 112, 9, 784m },
                    { 112, 10, 1941m },
                    { 112, 11, 55m },
                    { 112, 12, 141m },
                    { 112, 13, 16m },
                    { 112, 14, 272m },
                    { 112, 15, 2m },
                    { 113, 1, 321m },
                    { 113, 2, 12m },
                    { 113, 3, 24m },
                    { 113, 4, 2m },
                    { 113, 6, 7m },
                    { 113, 7, 19m },
                    { 113, 8, 516m },
                    { 113, 9, 616m },
                    { 113, 10, 3666m },
                    { 113, 11, 64m },
                    { 113, 12, 107m },
                    { 113, 13, 5m },
                    { 114, 1, 181m },
                    { 114, 2, 19m },
                    { 114, 3, 3m },
                    { 114, 4, 5m },
                    { 114, 6, 10m },
                    { 114, 7, 8m },
                    { 114, 9, 145m },
                    { 114, 10, 905m },
                    { 114, 11, 26m },
                    { 114, 12, 213m },
                    { 114, 13, 0m },
                    { 114, 14, 274m },
                    { 114, 15, 0m },
                    { 115, 1, 184m },
                    { 115, 2, 1m },
                    { 115, 3, 7m },
                    { 115, 4, 1m },
                    { 115, 5, 28m },
                    { 115, 7, 11m },
                    { 115, 8, 731m },
                    { 115, 9, 833m },
                    { 115, 11, 13m },
                    { 115, 13, 2m },
                    { 115, 14, 4m },
                    { 115, 15, 1m },
                    { 116, 1, 256m },
                    { 116, 2, 26m },
                    { 116, 3, 7m },
                    { 116, 4, 6m },
                    { 116, 5, 7m },
                    { 116, 6, 2m },
                    { 116, 9, 774m },
                    { 116, 11, 4m },
                    { 116, 14, 151m },
                    { 116, 15, 3m },
                    { 117, 1, 244m },
                    { 117, 2, 29m },
                    { 117, 4, 5m },
                    { 117, 5, 47m },
                    { 117, 6, 0m },
                    { 117, 12, 309m },
                    { 117, 13, 12m },
                    { 117, 14, 11m },
                    { 117, 15, 4m },
                    { 118, 1, 392m },
                    { 118, 2, 11m },
                    { 118, 3, 26m },
                    { 118, 6, 14m },
                    { 118, 7, 17m },
                    { 118, 9, 989m },
                    { 118, 12, 217m },
                    { 118, 13, 14m },
                    { 118, 14, 29m },
                    { 118, 15, 2m },
                    { 119, 1, 203m },
                    { 119, 2, 29m },
                    { 119, 4, 4m },
                    { 119, 7, 10m },
                    { 119, 8, 877m },
                    { 119, 9, 821m },
                    { 119, 10, 3201m },
                    { 119, 12, 412m },
                    { 120, 1, 76m },
                    { 120, 2, 28m },
                    { 120, 5, 0m },
                    { 120, 7, 5m },
                    { 120, 9, 88m },
                    { 120, 10, 4396m },
                    { 120, 11, 89m },
                    { 120, 12, 156m },
                    { 120, 13, 17m },
                    { 120, 14, 234m },
                    { 120, 15, 0m },
                    { 121, 1, 124m },
                    { 121, 2, 11m },
                    { 121, 3, 23m },
                    { 121, 4, 8m },
                    { 121, 5, 1m },
                    { 121, 6, 3m },
                    { 121, 7, 0m },
                    { 121, 8, 679m },
                    { 121, 11, 23m },
                    { 121, 13, 4m },
                    { 121, 14, 328m },
                    { 121, 15, 4m },
                    { 122, 1, 154m },
                    { 122, 2, 15m },
                    { 122, 3, 5m },
                    { 122, 6, 7m },
                    { 122, 8, 39m },
                    { 122, 9, 401m },
                    { 122, 11, 45m },
                    { 122, 12, 143m },
                    { 122, 13, 11m },
                    { 122, 14, 367m },
                    { 122, 15, 1m },
                    { 123, 1, 299m },
                    { 123, 2, 0m },
                    { 123, 3, 10m },
                    { 123, 4, 8m },
                    { 123, 5, 28m },
                    { 123, 6, 0m },
                    { 123, 8, 199m },
                    { 123, 9, 480m },
                    { 123, 10, 3707m },
                    { 123, 11, 84m },
                    { 123, 12, 497m },
                    { 123, 13, 9m },
                    { 123, 15, 1m },
                    { 124, 1, 244m },
                    { 124, 2, 19m },
                    { 124, 4, 9m },
                    { 124, 5, 42m },
                    { 124, 7, 5m },
                    { 124, 8, 223m },
                    { 124, 9, 288m },
                    { 124, 10, 2387m },
                    { 124, 11, 33m },
                    { 124, 15, 5m },
                    { 125, 1, 312m },
                    { 125, 2, 24m },
                    { 125, 5, 14m },
                    { 125, 7, 13m },
                    { 125, 8, 543m },
                    { 125, 10, 2504m },
                    { 125, 11, 12m },
                    { 125, 12, 247m },
                    { 125, 13, 7m },
                    { 125, 15, 3m },
                    { 126, 1, 342m },
                    { 126, 2, 17m },
                    { 126, 3, 15m },
                    { 126, 4, 1m },
                    { 126, 5, 37m },
                    { 126, 6, 12m },
                    { 126, 7, 5m },
                    { 126, 9, 404m },
                    { 126, 11, 25m },
                    { 126, 12, 441m },
                    { 126, 13, 3m },
                    { 126, 14, 285m },
                    { 126, 15, 4m },
                    { 127, 1, 88m },
                    { 127, 2, 12m },
                    { 127, 3, 8m },
                    { 127, 4, 6m },
                    { 127, 5, 14m },
                    { 127, 6, 7m },
                    { 127, 8, 314m },
                    { 127, 9, 725m },
                    { 127, 10, 2782m },
                    { 127, 11, 85m },
                    { 127, 13, 10m },
                    { 127, 14, 154m },
                    { 128, 1, 55m },
                    { 128, 2, 13m },
                    { 128, 3, 25m },
                    { 128, 4, 6m },
                    { 128, 5, 27m },
                    { 128, 7, 11m },
                    { 128, 9, 416m },
                    { 128, 11, 89m },
                    { 128, 13, 18m },
                    { 128, 15, 1m },
                    { 129, 1, 77m },
                    { 129, 2, 26m },
                    { 129, 3, 14m },
                    { 129, 4, 7m },
                    { 129, 6, 1m },
                    { 129, 9, 228m },
                    { 129, 10, 2265m },
                    { 129, 11, 86m },
                    { 129, 12, 113m },
                    { 129, 14, 63m },
                    { 129, 15, 5m },
                    { 130, 1, 45m },
                    { 130, 2, 20m },
                    { 130, 4, 3m },
                    { 130, 5, 24m },
                    { 130, 6, 2m },
                    { 130, 8, 970m },
                    { 130, 11, 77m },
                    { 130, 14, 389m },
                    { 130, 15, 0m },
                    { 131, 1, 395m },
                    { 131, 2, 4m },
                    { 131, 3, 13m },
                    { 131, 5, 47m },
                    { 131, 6, 13m },
                    { 131, 9, 431m },
                    { 131, 11, 22m },
                    { 131, 12, 345m },
                    { 131, 13, 8m },
                    { 132, 1, 169m },
                    { 132, 2, 14m },
                    { 132, 3, 21m },
                    { 132, 4, 4m },
                    { 132, 7, 13m },
                    { 132, 8, 11m },
                    { 132, 9, 159m },
                    { 132, 10, 4370m },
                    { 132, 11, 95m },
                    { 132, 12, 211m },
                    { 132, 14, 296m },
                    { 132, 15, 4m },
                    { 133, 1, 320m },
                    { 133, 2, 8m },
                    { 133, 3, 26m },
                    { 133, 4, 2m },
                    { 133, 6, 13m },
                    { 133, 7, 19m },
                    { 133, 8, 294m },
                    { 133, 10, 3159m },
                    { 133, 11, 30m },
                    { 133, 12, 165m },
                    { 133, 13, 9m },
                    { 133, 14, 335m },
                    { 133, 15, 1m },
                    { 134, 1, 303m },
                    { 134, 2, 16m },
                    { 134, 3, 24m },
                    { 134, 5, 16m },
                    { 134, 7, 3m },
                    { 134, 9, 957m },
                    { 134, 10, 2045m },
                    { 134, 12, 185m },
                    { 134, 13, 1m },
                    { 134, 15, 2m },
                    { 135, 1, 318m },
                    { 135, 2, 15m },
                    { 135, 6, 4m },
                    { 135, 7, 0m },
                    { 135, 8, 453m },
                    { 135, 9, 493m },
                    { 135, 12, 107m },
                    { 135, 13, 5m },
                    { 135, 14, 140m },
                    { 135, 15, 2m },
                    { 136, 1, 144m },
                    { 136, 2, 4m },
                    { 136, 3, 9m },
                    { 136, 4, 0m },
                    { 136, 5, 20m },
                    { 136, 7, 3m },
                    { 136, 8, 287m },
                    { 136, 9, 586m },
                    { 136, 10, 3304m },
                    { 136, 11, 24m },
                    { 136, 13, 10m },
                    { 136, 14, 377m },
                    { 136, 15, 3m },
                    { 137, 1, 271m },
                    { 137, 2, 6m },
                    { 137, 3, 23m },
                    { 137, 4, 0m },
                    { 137, 5, 6m },
                    { 137, 6, 0m },
                    { 137, 9, 916m },
                    { 137, 10, 4771m },
                    { 137, 12, 150m },
                    { 137, 13, 16m },
                    { 137, 14, 259m },
                    { 138, 1, 257m },
                    { 138, 2, 6m },
                    { 138, 5, 42m },
                    { 138, 7, 9m },
                    { 138, 9, 236m },
                    { 138, 10, 2058m },
                    { 138, 11, 13m },
                    { 138, 12, 79m },
                    { 138, 14, 94m },
                    { 138, 15, 4m },
                    { 139, 1, 138m },
                    { 139, 2, 19m },
                    { 139, 3, 7m },
                    { 139, 5, 25m },
                    { 139, 6, 14m },
                    { 139, 7, 9m },
                    { 139, 10, 1528m },
                    { 139, 11, 87m },
                    { 139, 12, 50m },
                    { 139, 13, 10m },
                    { 139, 14, 163m },
                    { 140, 1, 334m },
                    { 140, 2, 0m },
                    { 140, 4, 6m },
                    { 140, 5, 5m },
                    { 140, 6, 14m },
                    { 140, 7, 15m },
                    { 140, 8, 482m },
                    { 140, 9, 979m },
                    { 140, 10, 4865m },
                    { 140, 12, 316m },
                    { 140, 13, 4m },
                    { 140, 14, 88m },
                    { 141, 1, 202m },
                    { 141, 2, 11m },
                    { 141, 3, 3m },
                    { 141, 6, 3m },
                    { 141, 7, 8m },
                    { 141, 9, 720m },
                    { 141, 11, 46m },
                    { 141, 12, 88m },
                    { 141, 13, 2m },
                    { 141, 14, 72m },
                    { 142, 1, 308m },
                    { 142, 2, 22m },
                    { 142, 3, 7m },
                    { 142, 5, 42m },
                    { 142, 6, 8m },
                    { 142, 7, 12m },
                    { 142, 11, 86m },
                    { 142, 15, 0m },
                    { 143, 1, 284m },
                    { 143, 2, 25m },
                    { 143, 5, 8m },
                    { 143, 6, 1m },
                    { 143, 7, 1m },
                    { 143, 8, 311m },
                    { 143, 11, 57m },
                    { 143, 12, 277m },
                    { 143, 13, 19m },
                    { 143, 14, 279m },
                    { 143, 15, 0m },
                    { 144, 1, 389m },
                    { 144, 2, 12m },
                    { 144, 4, 3m },
                    { 144, 5, 5m },
                    { 144, 6, 7m },
                    { 144, 9, 317m },
                    { 144, 12, 58m },
                    { 144, 13, 15m },
                    { 144, 14, 104m },
                    { 144, 15, 5m },
                    { 145, 1, 108m },
                    { 145, 2, 12m },
                    { 145, 4, 4m },
                    { 145, 5, 35m },
                    { 145, 6, 0m },
                    { 145, 7, 3m },
                    { 145, 9, 50m },
                    { 145, 10, 3770m },
                    { 145, 11, 98m },
                    { 145, 12, 396m },
                    { 145, 13, 19m },
                    { 145, 14, 117m },
                    { 145, 15, 1m },
                    { 146, 1, 341m },
                    { 146, 2, 25m },
                    { 146, 3, 27m },
                    { 146, 4, 8m },
                    { 146, 6, 13m },
                    { 146, 7, 0m },
                    { 146, 9, 817m },
                    { 146, 10, 4074m },
                    { 146, 12, 48m },
                    { 146, 13, 16m },
                    { 146, 14, 67m },
                    { 146, 15, 1m },
                    { 147, 1, 348m },
                    { 147, 2, 14m },
                    { 147, 6, 14m },
                    { 147, 7, 4m },
                    { 147, 8, 854m },
                    { 147, 9, 133m },
                    { 147, 10, 1805m },
                    { 147, 14, 290m },
                    { 147, 15, 2m },
                    { 148, 1, 385m },
                    { 148, 2, 29m },
                    { 148, 4, 8m },
                    { 148, 6, 6m },
                    { 148, 8, 563m },
                    { 148, 9, 828m },
                    { 148, 10, 204m },
                    { 148, 11, 64m },
                    { 148, 12, 16m },
                    { 148, 13, 8m },
                    { 148, 14, 384m },
                    { 148, 15, 5m },
                    { 149, 1, 383m },
                    { 149, 2, 22m },
                    { 149, 3, 23m },
                    { 149, 4, 6m },
                    { 149, 6, 7m },
                    { 149, 7, 1m },
                    { 149, 8, 347m },
                    { 149, 10, 3624m },
                    { 149, 11, 68m },
                    { 149, 13, 9m },
                    { 149, 14, 11m },
                    { 149, 15, 3m },
                    { 150, 1, 180m },
                    { 150, 2, 3m },
                    { 150, 3, 29m },
                    { 150, 4, 0m },
                    { 150, 6, 14m },
                    { 150, 7, 9m },
                    { 150, 8, 656m },
                    { 150, 9, 115m },
                    { 150, 10, 3507m },
                    { 150, 11, 80m },
                    { 150, 12, 283m },
                    { 150, 14, 95m },
                    { 150, 15, 3m },
                    { 151, 1, 83m },
                    { 151, 2, 23m },
                    { 151, 3, 14m },
                    { 151, 5, 48m },
                    { 151, 8, 342m },
                    { 151, 9, 585m },
                    { 151, 10, 397m },
                    { 151, 11, 39m },
                    { 151, 13, 17m },
                    { 151, 15, 0m },
                    { 152, 1, 361m },
                    { 152, 2, 23m },
                    { 152, 3, 6m },
                    { 152, 7, 9m },
                    { 152, 9, 903m },
                    { 152, 11, 48m },
                    { 152, 12, 377m },
                    { 152, 13, 9m },
                    { 152, 14, 233m },
                    { 153, 1, 319m },
                    { 153, 2, 22m },
                    { 153, 3, 26m },
                    { 153, 5, 11m },
                    { 153, 6, 12m },
                    { 153, 7, 4m },
                    { 153, 8, 495m },
                    { 153, 9, 664m },
                    { 153, 10, 4686m },
                    { 153, 12, 366m },
                    { 153, 13, 13m },
                    { 153, 15, 5m },
                    { 154, 1, 245m },
                    { 154, 2, 27m },
                    { 154, 3, 17m },
                    { 154, 5, 16m },
                    { 154, 6, 10m },
                    { 154, 8, 862m },
                    { 154, 12, 275m },
                    { 154, 13, 16m },
                    { 154, 14, 221m },
                    { 154, 15, 4m },
                    { 155, 1, 57m },
                    { 155, 2, 8m },
                    { 155, 3, 10m },
                    { 155, 4, 8m },
                    { 155, 7, 16m },
                    { 155, 9, 55m },
                    { 155, 10, 1615m },
                    { 155, 11, 86m },
                    { 155, 12, 75m },
                    { 155, 13, 13m },
                    { 155, 14, 248m },
                    { 155, 15, 0m },
                    { 156, 1, 290m },
                    { 156, 2, 6m },
                    { 156, 3, 8m },
                    { 156, 4, 8m },
                    { 156, 9, 130m },
                    { 156, 11, 67m },
                    { 156, 12, 438m },
                    { 157, 1, 237m },
                    { 157, 2, 6m },
                    { 157, 3, 6m },
                    { 157, 4, 9m },
                    { 157, 5, 20m },
                    { 157, 6, 2m },
                    { 157, 8, 165m },
                    { 157, 10, 3248m },
                    { 157, 11, 83m },
                    { 157, 13, 14m },
                    { 157, 15, 3m },
                    { 158, 1, 15m },
                    { 158, 2, 22m },
                    { 158, 3, 6m },
                    { 158, 4, 3m },
                    { 158, 5, 31m },
                    { 158, 6, 9m },
                    { 158, 7, 9m },
                    { 158, 8, 106m },
                    { 158, 9, 482m },
                    { 158, 11, 51m },
                    { 158, 12, 14m },
                    { 158, 13, 18m },
                    { 158, 15, 0m },
                    { 159, 1, 186m },
                    { 159, 2, 1m },
                    { 159, 5, 16m },
                    { 159, 6, 1m },
                    { 159, 8, 380m },
                    { 159, 9, 928m },
                    { 159, 11, 60m },
                    { 159, 13, 14m },
                    { 159, 14, 56m },
                    { 159, 15, 0m },
                    { 160, 1, 255m },
                    { 160, 2, 26m },
                    { 160, 3, 22m },
                    { 160, 4, 5m },
                    { 160, 5, 42m },
                    { 160, 6, 8m },
                    { 160, 7, 18m },
                    { 160, 8, 457m },
                    { 160, 9, 217m },
                    { 160, 12, 446m },
                    { 160, 13, 1m },
                    { 160, 14, 386m },
                    { 161, 1, 230m },
                    { 161, 2, 12m },
                    { 161, 3, 10m },
                    { 161, 4, 2m },
                    { 161, 5, 29m },
                    { 161, 6, 8m },
                    { 161, 8, 582m },
                    { 161, 9, 595m },
                    { 161, 10, 4619m },
                    { 161, 11, 3m },
                    { 161, 12, 189m },
                    { 161, 13, 2m },
                    { 161, 14, 152m },
                    { 161, 15, 1m },
                    { 162, 1, 303m },
                    { 162, 2, 28m },
                    { 162, 4, 3m },
                    { 162, 5, 25m },
                    { 162, 6, 1m },
                    { 162, 7, 9m },
                    { 162, 9, 596m },
                    { 162, 10, 3874m },
                    { 162, 11, 27m },
                    { 162, 12, 310m },
                    { 162, 13, 16m },
                    { 163, 1, 106m },
                    { 163, 2, 14m },
                    { 163, 3, 25m },
                    { 163, 4, 2m },
                    { 163, 5, 49m },
                    { 163, 6, 14m },
                    { 163, 8, 890m },
                    { 163, 9, 835m },
                    { 163, 10, 318m },
                    { 163, 11, 45m },
                    { 163, 13, 11m },
                    { 163, 14, 357m },
                    { 164, 1, 339m },
                    { 164, 2, 6m },
                    { 164, 3, 24m },
                    { 164, 4, 3m },
                    { 164, 5, 46m },
                    { 164, 7, 18m },
                    { 164, 8, 672m },
                    { 164, 9, 844m },
                    { 164, 10, 2501m },
                    { 164, 11, 34m },
                    { 164, 12, 339m },
                    { 164, 13, 18m },
                    { 164, 14, 336m },
                    { 164, 15, 0m },
                    { 165, 1, 149m },
                    { 165, 2, 28m },
                    { 165, 3, 19m },
                    { 165, 4, 6m },
                    { 165, 5, 4m },
                    { 165, 7, 3m },
                    { 165, 8, 571m },
                    { 165, 10, 4409m },
                    { 165, 11, 91m },
                    { 165, 12, 195m },
                    { 165, 13, 12m },
                    { 165, 14, 377m },
                    { 166, 1, 159m },
                    { 166, 2, 13m },
                    { 166, 3, 28m },
                    { 166, 4, 8m },
                    { 166, 5, 16m },
                    { 166, 6, 8m },
                    { 166, 7, 7m },
                    { 166, 8, 167m },
                    { 166, 9, 899m },
                    { 166, 10, 3930m },
                    { 166, 12, 268m },
                    { 166, 13, 5m },
                    { 166, 14, 0m },
                    { 167, 1, 219m },
                    { 167, 2, 14m },
                    { 167, 4, 7m },
                    { 167, 5, 34m },
                    { 167, 6, 5m },
                    { 167, 8, 136m },
                    { 167, 9, 842m },
                    { 167, 11, 18m },
                    { 167, 12, 362m },
                    { 167, 13, 0m },
                    { 167, 14, 241m },
                    { 167, 15, 0m },
                    { 168, 1, 335m },
                    { 168, 2, 6m },
                    { 168, 3, 18m },
                    { 168, 4, 1m },
                    { 168, 5, 47m },
                    { 168, 7, 9m },
                    { 168, 9, 849m },
                    { 168, 10, 3485m },
                    { 168, 12, 302m },
                    { 168, 13, 4m },
                    { 169, 1, 55m },
                    { 169, 2, 28m },
                    { 169, 3, 19m },
                    { 169, 5, 9m },
                    { 169, 6, 13m },
                    { 169, 7, 11m },
                    { 169, 8, 415m },
                    { 169, 10, 3759m },
                    { 169, 11, 97m },
                    { 169, 13, 10m },
                    { 169, 14, 160m },
                    { 169, 15, 4m },
                    { 170, 1, 159m },
                    { 170, 2, 24m },
                    { 170, 3, 28m },
                    { 170, 5, 38m },
                    { 170, 6, 14m },
                    { 170, 7, 12m },
                    { 170, 9, 210m },
                    { 170, 10, 4374m },
                    { 170, 11, 62m },
                    { 170, 12, 98m },
                    { 170, 13, 18m },
                    { 170, 14, 95m },
                    { 171, 1, 257m },
                    { 171, 2, 15m },
                    { 171, 4, 7m },
                    { 171, 5, 28m },
                    { 171, 7, 17m },
                    { 171, 8, 301m },
                    { 171, 9, 875m },
                    { 171, 10, 4103m },
                    { 171, 12, 282m },
                    { 171, 14, 173m },
                    { 171, 15, 4m },
                    { 172, 1, 318m },
                    { 172, 2, 29m },
                    { 172, 4, 2m },
                    { 172, 5, 22m },
                    { 172, 7, 17m },
                    { 172, 8, 463m },
                    { 172, 9, 435m },
                    { 172, 13, 13m },
                    { 172, 14, 303m },
                    { 172, 15, 4m },
                    { 173, 1, 304m },
                    { 173, 2, 24m },
                    { 173, 3, 24m },
                    { 173, 4, 0m },
                    { 173, 5, 16m },
                    { 173, 7, 7m },
                    { 173, 8, 748m },
                    { 173, 9, 676m },
                    { 173, 10, 266m },
                    { 173, 11, 52m },
                    { 173, 12, 480m },
                    { 173, 13, 4m },
                    { 173, 15, 1m },
                    { 174, 1, 190m },
                    { 174, 2, 5m },
                    { 174, 3, 23m },
                    { 174, 4, 9m },
                    { 174, 6, 5m },
                    { 174, 8, 10m },
                    { 174, 9, 154m },
                    { 174, 10, 2808m },
                    { 174, 12, 171m },
                    { 174, 13, 9m },
                    { 174, 14, 168m },
                    { 174, 15, 3m },
                    { 175, 1, 360m },
                    { 175, 2, 7m },
                    { 175, 3, 21m },
                    { 175, 5, 12m },
                    { 175, 8, 813m },
                    { 175, 9, 451m },
                    { 175, 11, 37m },
                    { 175, 12, 482m },
                    { 175, 13, 3m },
                    { 175, 15, 2m },
                    { 176, 1, 388m },
                    { 176, 2, 11m },
                    { 176, 3, 14m },
                    { 176, 4, 8m },
                    { 176, 5, 33m },
                    { 176, 6, 0m },
                    { 176, 8, 727m },
                    { 176, 10, 433m },
                    { 176, 11, 57m },
                    { 176, 12, 352m },
                    { 176, 13, 17m },
                    { 176, 15, 3m },
                    { 177, 1, 381m },
                    { 177, 2, 13m },
                    { 177, 4, 8m },
                    { 177, 5, 27m },
                    { 177, 6, 12m },
                    { 177, 7, 6m },
                    { 177, 8, 135m },
                    { 177, 9, 250m },
                    { 177, 10, 4679m },
                    { 177, 12, 122m },
                    { 177, 13, 13m },
                    { 177, 15, 5m },
                    { 178, 1, 51m },
                    { 178, 2, 17m },
                    { 178, 4, 9m },
                    { 178, 7, 19m },
                    { 178, 8, 454m },
                    { 178, 9, 840m },
                    { 178, 10, 1750m },
                    { 178, 11, 13m },
                    { 178, 12, 163m },
                    { 178, 15, 0m },
                    { 179, 1, 280m },
                    { 179, 2, 4m },
                    { 179, 3, 23m },
                    { 179, 4, 4m },
                    { 179, 5, 14m },
                    { 179, 6, 2m },
                    { 179, 7, 14m },
                    { 179, 9, 753m },
                    { 179, 10, 4237m },
                    { 179, 12, 86m },
                    { 179, 13, 15m },
                    { 179, 14, 41m },
                    { 180, 1, 21m },
                    { 180, 2, 18m },
                    { 180, 3, 22m },
                    { 180, 4, 5m },
                    { 180, 5, 38m },
                    { 180, 6, 6m },
                    { 180, 7, 6m },
                    { 180, 8, 508m },
                    { 180, 11, 10m },
                    { 180, 12, 438m },
                    { 181, 1, 162m },
                    { 181, 2, 29m },
                    { 181, 3, 6m },
                    { 181, 4, 1m },
                    { 181, 5, 46m },
                    { 181, 7, 12m },
                    { 181, 8, 871m },
                    { 181, 9, 558m },
                    { 181, 10, 2936m },
                    { 181, 12, 321m },
                    { 181, 13, 3m },
                    { 181, 14, 212m },
                    { 181, 15, 1m },
                    { 182, 1, 46m },
                    { 182, 2, 3m },
                    { 182, 3, 10m },
                    { 182, 5, 39m },
                    { 182, 6, 1m },
                    { 182, 7, 5m },
                    { 182, 8, 864m },
                    { 182, 9, 58m },
                    { 182, 10, 1329m },
                    { 182, 11, 67m },
                    { 182, 12, 110m },
                    { 182, 13, 0m },
                    { 182, 14, 365m },
                    { 182, 15, 1m },
                    { 183, 1, 240m },
                    { 183, 2, 6m },
                    { 183, 4, 9m },
                    { 183, 5, 30m },
                    { 183, 7, 5m },
                    { 183, 8, 242m },
                    { 183, 9, 933m },
                    { 183, 10, 1426m },
                    { 183, 11, 31m },
                    { 183, 13, 7m },
                    { 183, 14, 185m },
                    { 183, 15, 4m },
                    { 184, 1, 343m },
                    { 184, 2, 22m },
                    { 184, 4, 0m },
                    { 184, 6, 8m },
                    { 184, 7, 4m },
                    { 184, 9, 372m },
                    { 184, 10, 3657m },
                    { 184, 12, 323m },
                    { 184, 14, 248m },
                    { 185, 1, 342m },
                    { 185, 2, 23m },
                    { 185, 3, 6m },
                    { 185, 5, 12m },
                    { 185, 6, 14m },
                    { 185, 7, 6m },
                    { 185, 8, 92m },
                    { 185, 9, 620m },
                    { 185, 10, 1309m },
                    { 185, 12, 324m },
                    { 185, 13, 14m },
                    { 185, 15, 2m },
                    { 186, 1, 390m },
                    { 186, 2, 13m },
                    { 186, 4, 9m },
                    { 186, 6, 1m },
                    { 186, 7, 18m },
                    { 186, 9, 879m },
                    { 186, 10, 3664m },
                    { 186, 11, 92m },
                    { 186, 13, 11m },
                    { 186, 14, 96m },
                    { 186, 15, 3m },
                    { 187, 1, 350m },
                    { 187, 2, 11m },
                    { 187, 4, 9m },
                    { 187, 7, 0m },
                    { 187, 8, 220m },
                    { 187, 12, 264m },
                    { 187, 13, 12m },
                    { 187, 15, 2m },
                    { 188, 1, 270m },
                    { 188, 2, 11m },
                    { 188, 4, 3m },
                    { 188, 5, 23m },
                    { 188, 6, 12m },
                    { 188, 7, 14m },
                    { 188, 8, 478m },
                    { 188, 9, 619m },
                    { 188, 11, 11m },
                    { 188, 12, 394m },
                    { 188, 13, 19m },
                    { 188, 15, 2m },
                    { 189, 1, 97m },
                    { 189, 2, 26m },
                    { 189, 4, 8m },
                    { 189, 6, 12m },
                    { 189, 9, 917m },
                    { 189, 11, 18m },
                    { 189, 12, 374m },
                    { 189, 14, 194m },
                    { 189, 15, 3m },
                    { 190, 1, 43m },
                    { 190, 2, 11m },
                    { 190, 3, 29m },
                    { 190, 4, 5m },
                    { 190, 6, 10m },
                    { 190, 7, 9m },
                    { 190, 12, 479m },
                    { 190, 13, 14m },
                    { 190, 14, 78m },
                    { 190, 15, 3m },
                    { 191, 1, 96m },
                    { 191, 2, 20m },
                    { 191, 3, 15m },
                    { 191, 5, 40m },
                    { 191, 8, 580m },
                    { 191, 9, 907m },
                    { 191, 10, 4403m },
                    { 191, 11, 43m },
                    { 191, 12, 301m },
                    { 191, 13, 13m },
                    { 191, 14, 321m },
                    { 191, 15, 0m },
                    { 192, 1, 184m },
                    { 192, 2, 26m },
                    { 192, 5, 42m },
                    { 192, 6, 5m },
                    { 192, 7, 3m },
                    { 192, 8, 45m },
                    { 192, 11, 87m },
                    { 192, 14, 200m },
                    { 193, 1, 126m },
                    { 193, 2, 10m },
                    { 193, 5, 4m },
                    { 193, 6, 3m },
                    { 193, 7, 15m },
                    { 193, 8, 862m },
                    { 193, 9, 707m },
                    { 193, 11, 89m },
                    { 193, 12, 1m },
                    { 193, 14, 52m },
                    { 193, 15, 3m },
                    { 194, 1, 197m },
                    { 194, 2, 11m },
                    { 194, 3, 25m },
                    { 194, 4, 4m },
                    { 194, 6, 1m },
                    { 194, 7, 2m },
                    { 194, 8, 153m },
                    { 194, 9, 446m },
                    { 194, 10, 4271m },
                    { 194, 12, 202m },
                    { 194, 13, 3m },
                    { 194, 14, 142m },
                    { 194, 15, 1m },
                    { 195, 1, 133m },
                    { 195, 2, 21m },
                    { 195, 3, 10m },
                    { 195, 4, 1m },
                    { 195, 6, 11m },
                    { 195, 7, 9m },
                    { 195, 8, 550m },
                    { 195, 9, 539m },
                    { 195, 10, 3879m },
                    { 195, 11, 54m },
                    { 195, 12, 207m },
                    { 195, 13, 1m },
                    { 196, 1, 137m },
                    { 196, 2, 8m },
                    { 196, 3, 3m },
                    { 196, 5, 13m },
                    { 196, 7, 3m },
                    { 196, 8, 983m },
                    { 196, 9, 167m },
                    { 196, 10, 2558m },
                    { 196, 11, 17m },
                    { 196, 12, 156m },
                    { 196, 14, 174m },
                    { 196, 15, 5m },
                    { 197, 1, 168m },
                    { 197, 2, 5m },
                    { 197, 3, 3m },
                    { 197, 4, 3m },
                    { 197, 5, 8m },
                    { 197, 7, 17m },
                    { 197, 9, 504m },
                    { 197, 12, 100m },
                    { 197, 14, 196m },
                    { 198, 1, 150m },
                    { 198, 2, 17m },
                    { 198, 4, 7m },
                    { 198, 5, 45m },
                    { 198, 7, 16m },
                    { 198, 10, 2705m },
                    { 198, 11, 9m },
                    { 198, 12, 397m },
                    { 198, 13, 16m },
                    { 198, 14, 271m },
                    { 199, 1, 188m },
                    { 199, 2, 8m },
                    { 199, 3, 8m },
                    { 199, 5, 19m },
                    { 199, 7, 9m },
                    { 199, 8, 820m },
                    { 199, 12, 3m },
                    { 199, 14, 282m },
                    { 200, 1, 398m },
                    { 200, 2, 6m },
                    { 200, 3, 20m },
                    { 200, 4, 4m },
                    { 200, 5, 23m },
                    { 200, 7, 8m },
                    { 200, 8, 487m },
                    { 200, 9, 512m },
                    { 200, 11, 79m },
                    { 200, 12, 174m },
                    { 200, 13, 2m },
                    { 200, 14, 215m },
                    { 200, 15, 1m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 1, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 1, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 1, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 1, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 2, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 2, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 2, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 2, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 2, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 2, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 2, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 2, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 3, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 3, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 3, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 3, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 3, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 4, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 4, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 4, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 4, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 4, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 5, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 5, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 5, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 5, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 5, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 5, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 5, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 5, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 5, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 6, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 6, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 6, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 6, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 6, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 7, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 7, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 7, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 7, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 7, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 7, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 7, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 7, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 7, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 7, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 8, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 8, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 8, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 8, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 8, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 8, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 8, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 8, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 8, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 8, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 8, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 9, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 9, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 9, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 9, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 9, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 9, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 9, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 9, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 9, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 9, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 9, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 9, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 9, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 10, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 10, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 10, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 10, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 10, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 10, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 10, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 11, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 11, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 11, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 11, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 11, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 11, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 11, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 11, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 11, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 11, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 11, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 12, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 12, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 12, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 12, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 12, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 12, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 12, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 12, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 12, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 12, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 13, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 13, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 13, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 13, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 13, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 13, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 13, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 13, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 13, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 13, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 13, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 13, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 14, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 14, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 14, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 14, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 14, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 14, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 14, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 14, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 14, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 14, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 14, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 14, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 14, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 15, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 15, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 15, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 15, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 15, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 15, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 15, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 15, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 15, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 15, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 15, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 15, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 16, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 16, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 16, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 16, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 16, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 16, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 16, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 16, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 16, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 16, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 16, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 17, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 17, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 17, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 17, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 17, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 17, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 17, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 17, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 17, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 17, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 17, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 17, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 17, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 17, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 18, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 18, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 18, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 18, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 18, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 18, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 18, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 18, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 18, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 18, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 18, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 18, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 18, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 19, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 19, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 19, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 19, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 19, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 19, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 19, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 19, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 19, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 19, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 19, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 19, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 19, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 20, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 20, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 20, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 20, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 20, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 20, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 20, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 20, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 21, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 21, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 21, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 21, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 21, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 21, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 21, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 21, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 21, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 21, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 22, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 22, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 22, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 22, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 22, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 22, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 22, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 22, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 22, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 22, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 22, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 23, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 23, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 23, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 23, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 23, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 23, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 23, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 23, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 23, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 23, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 23, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 23, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 23, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 24, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 24, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 24, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 24, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 24, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 24, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 24, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 24, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 24, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 24, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 24, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 24, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 25, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 25, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 25, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 25, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 25, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 25, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 25, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 25, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 25, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 25, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 26, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 26, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 26, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 26, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 26, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 26, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 26, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 26, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 26, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 26, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 26, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 26, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 26, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 27, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 27, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 27, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 27, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 27, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 27, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 27, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 27, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 27, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 27, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 28, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 28, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 28, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 28, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 28, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 28, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 28, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 28, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 28, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 28, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 29, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 29, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 29, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 29, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 29, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 29, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 29, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 29, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 29, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 30, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 30, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 30, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 30, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 30, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 30, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 30, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 30, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 30, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 30, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 30, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 30, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 30, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 31, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 31, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 31, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 31, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 31, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 31, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 31, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 31, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 31, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 31, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 32, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 32, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 32, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 32, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 32, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 32, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 32, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 32, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 32, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 32, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 32, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 32, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 32, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 33, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 33, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 33, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 33, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 33, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 33, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 33, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 33, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 33, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 33, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 33, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 33, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 33, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 33, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 34, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 34, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 34, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 34, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 34, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 34, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 34, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 34, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 34, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 34, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 35, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 35, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 35, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 35, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 35, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 35, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 35, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 35, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 35, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 35, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 35, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 36, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 36, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 36, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 36, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 36, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 36, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 36, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 36, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 37, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 37, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 37, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 37, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 37, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 37, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 37, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 37, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 37, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 37, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 38, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 38, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 38, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 38, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 38, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 38, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 38, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 38, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 38, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 38, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 38, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 38, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 39, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 39, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 39, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 39, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 39, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 39, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 39, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 39, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 40, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 40, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 40, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 40, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 40, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 40, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 40, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 40, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 40, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 41, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 41, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 41, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 41, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 41, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 41, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 41, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 41, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 41, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 41, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 41, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 42, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 42, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 42, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 42, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 42, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 42, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 42, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 42, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 42, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 42, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 42, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 43, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 43, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 43, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 43, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 43, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 43, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 43, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 43, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 43, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 43, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 43, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 44, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 44, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 44, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 44, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 44, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 44, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 44, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 44, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 44, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 44, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 44, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 44, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 45, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 45, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 45, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 45, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 45, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 45, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 45, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 45, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 45, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 45, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 45, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 45, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 46, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 46, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 46, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 46, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 46, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 46, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 46, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 46, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 47, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 47, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 47, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 47, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 47, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 47, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 47, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 47, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 47, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 47, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 48, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 48, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 48, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 48, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 48, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 48, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 48, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 48, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 49, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 49, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 49, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 49, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 49, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 49, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 49, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 49, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 49, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 49, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 49, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 49, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 49, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 50, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 50, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 50, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 50, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 50, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 50, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 50, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 50, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 50, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 51, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 51, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 51, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 51, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 51, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 51, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 51, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 51, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 51, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 51, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 51, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 52, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 52, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 52, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 52, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 52, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 52, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 52, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 52, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 52, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 52, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 53, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 53, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 53, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 53, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 53, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 53, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 53, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 53, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 53, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 53, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 53, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 53, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 53, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 54, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 54, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 54, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 54, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 54, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 54, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 54, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 54, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 54, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 54, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 54, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 54, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 55, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 55, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 55, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 55, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 55, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 55, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 55, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 55, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 55, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 55, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 55, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 55, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 56, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 56, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 56, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 56, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 56, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 56, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 56, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 56, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 56, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 56, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 56, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 56, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 56, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 57, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 57, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 57, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 57, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 57, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 57, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 57, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 57, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 57, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 57, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 57, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 58, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 58, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 58, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 58, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 58, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 58, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 58, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 58, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 58, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 58, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 58, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 59, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 59, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 59, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 59, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 59, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 59, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 59, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 59, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 59, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 59, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 60, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 60, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 60, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 60, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 60, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 60, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 60, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 60, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 60, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 60, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 60, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 60, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 61, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 61, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 61, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 61, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 61, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 61, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 61, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 61, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 61, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 61, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 61, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 62, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 62, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 62, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 62, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 62, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 62, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 62, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 62, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 62, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 62, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 63, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 63, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 63, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 63, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 63, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 63, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 63, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 63, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 63, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 63, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 63, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 63, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 64, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 64, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 64, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 64, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 64, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 64, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 64, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 64, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 64, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 64, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 64, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 65, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 65, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 65, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 65, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 65, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 65, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 65, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 65, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 65, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 65, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 65, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 65, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 66, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 66, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 66, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 66, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 66, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 66, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 66, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 66, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 66, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 66, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 66, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 67, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 67, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 67, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 67, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 67, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 67, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 67, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 67, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 67, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 67, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 67, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 68, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 68, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 68, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 68, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 68, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 68, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 68, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 68, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 68, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 69, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 69, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 69, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 69, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 69, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 69, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 69, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 69, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 69, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 69, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 69, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 69, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 70, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 70, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 70, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 70, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 70, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 70, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 70, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 70, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 70, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 70, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 70, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 70, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 70, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 71, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 71, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 71, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 71, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 71, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 71, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 71, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 71, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 71, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 71, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 71, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 71, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 71, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 71, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 72, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 72, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 72, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 72, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 72, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 72, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 72, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 72, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 72, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 72, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 72, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 73, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 73, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 73, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 73, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 73, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 73, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 73, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 73, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 73, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 73, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 73, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 74, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 74, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 74, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 74, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 74, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 74, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 74, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 74, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 74, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 74, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 75, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 75, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 75, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 75, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 75, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 75, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 75, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 75, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 75, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 75, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 76, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 76, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 76, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 76, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 76, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 76, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 76, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 76, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 76, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 76, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 76, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 76, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 76, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 77, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 77, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 77, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 77, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 77, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 77, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 77, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 77, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 77, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 77, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 77, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 77, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 77, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 78, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 78, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 78, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 78, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 78, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 78, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 78, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 78, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 78, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 78, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 78, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 79, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 79, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 79, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 79, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 79, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 79, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 79, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 79, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 79, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 80, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 80, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 80, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 80, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 80, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 80, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 80, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 80, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 80, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 80, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 80, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 81, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 81, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 81, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 81, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 81, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 81, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 81, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 81, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 81, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 81, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 81, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 81, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 82, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 82, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 82, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 82, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 82, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 82, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 82, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 82, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 82, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 82, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 82, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 82, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 83, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 83, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 83, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 83, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 83, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 83, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 83, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 83, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 84, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 84, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 84, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 84, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 84, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 84, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 84, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 84, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 84, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 85, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 85, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 85, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 85, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 85, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 85, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 85, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 85, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 85, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 85, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 85, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 85, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 85, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 86, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 86, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 86, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 86, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 86, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 86, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 86, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 86, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 86, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 86, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 86, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 86, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 87, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 87, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 87, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 87, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 87, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 87, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 87, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 87, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 87, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 87, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 88, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 88, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 88, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 88, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 88, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 88, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 88, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 88, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 88, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 88, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 88, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 88, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 88, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 89, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 89, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 89, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 89, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 89, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 89, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 89, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 89, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 90, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 90, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 90, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 90, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 90, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 90, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 90, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 90, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 90, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 90, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 90, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 90, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 90, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 91, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 91, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 91, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 91, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 91, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 91, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 91, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 91, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 91, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 91, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 91, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 91, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 92, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 92, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 92, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 92, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 92, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 92, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 92, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 93, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 93, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 93, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 93, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 93, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 93, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 93, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 93, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 93, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 94, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 94, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 94, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 94, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 94, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 94, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 94, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 94, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 94, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 94, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 94, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 94, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 94, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 95, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 95, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 95, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 95, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 95, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 95, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 95, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 95, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 95, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 95, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 95, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 95, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 96, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 96, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 96, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 96, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 96, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 96, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 96, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 96, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 96, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 97, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 97, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 97, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 97, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 97, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 97, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 97, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 97, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 98, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 98, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 98, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 98, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 98, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 98, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 98, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 98, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 98, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 98, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 98, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 98, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 99, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 99, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 99, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 99, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 99, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 99, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 99, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 99, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 99, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 99, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 100, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 100, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 100, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 100, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 100, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 100, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 100, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 100, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 100, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 100, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 100, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 101, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 101, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 101, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 101, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 101, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 101, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 101, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 101, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 101, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 101, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 101, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 102, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 102, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 102, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 102, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 102, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 102, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 102, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 102, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 102, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 102, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 102, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 102, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 102, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 102, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 103, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 103, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 103, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 103, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 103, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 103, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 103, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 103, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 103, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 103, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 103, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 103, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 104, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 104, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 104, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 104, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 104, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 104, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 104, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 104, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 104, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 104, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 104, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 105, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 105, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 105, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 105, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 105, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 105, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 105, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 105, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 105, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 105, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 106, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 106, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 106, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 106, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 106, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 106, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 106, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 106, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 106, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 106, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 106, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 107, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 107, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 107, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 107, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 107, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 107, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 107, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 107, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 107, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 107, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 107, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 107, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 108, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 108, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 108, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 108, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 108, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 108, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 108, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 108, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 108, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 108, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 109, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 109, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 109, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 109, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 109, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 109, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 109, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 109, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 109, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 109, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 109, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 109, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 109, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 110, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 110, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 110, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 110, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 110, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 110, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 110, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 110, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 111, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 111, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 111, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 111, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 111, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 111, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 111, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 111, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 111, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 111, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 111, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 112, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 112, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 112, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 112, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 112, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 112, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 112, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 112, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 112, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 112, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 112, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 112, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 112, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 113, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 113, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 113, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 113, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 113, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 113, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 113, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 113, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 113, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 113, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 113, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 113, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 114, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 114, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 114, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 114, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 114, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 114, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 114, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 114, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 114, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 114, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 114, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 114, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 114, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 115, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 115, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 115, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 115, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 115, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 115, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 115, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 115, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 115, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 115, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 115, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 115, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 116, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 116, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 116, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 116, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 116, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 116, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 116, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 116, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 116, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 116, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 117, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 117, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 117, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 117, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 117, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 117, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 117, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 117, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 117, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 118, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 118, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 118, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 118, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 118, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 118, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 118, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 118, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 118, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 118, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 119, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 119, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 119, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 119, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 119, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 119, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 119, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 119, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 120, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 120, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 120, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 120, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 120, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 120, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 120, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 120, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 120, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 120, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 120, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 121, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 121, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 121, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 121, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 121, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 121, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 121, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 121, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 121, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 121, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 121, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 121, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 122, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 122, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 122, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 122, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 122, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 122, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 122, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 122, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 122, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 122, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 122, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 123, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 123, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 123, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 123, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 123, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 123, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 123, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 123, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 123, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 123, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 123, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 123, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 123, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 124, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 124, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 124, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 124, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 124, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 124, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 124, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 124, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 124, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 124, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 125, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 125, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 125, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 125, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 125, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 125, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 125, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 125, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 125, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 125, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 126, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 126, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 126, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 126, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 126, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 126, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 126, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 126, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 126, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 126, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 126, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 126, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 126, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 127, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 127, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 127, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 127, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 127, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 127, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 127, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 127, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 127, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 127, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 127, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 127, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 128, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 128, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 128, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 128, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 128, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 128, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 128, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 128, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 128, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 128, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 129, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 129, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 129, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 129, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 129, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 129, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 129, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 129, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 129, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 129, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 129, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 130, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 130, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 130, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 130, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 130, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 130, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 130, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 130, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 130, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 131, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 131, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 131, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 131, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 131, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 131, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 131, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 131, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 131, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 132, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 132, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 132, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 132, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 132, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 132, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 132, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 132, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 132, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 132, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 132, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 132, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 133, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 133, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 133, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 133, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 133, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 133, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 133, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 133, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 133, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 133, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 133, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 133, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 133, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 134, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 134, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 134, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 134, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 134, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 134, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 134, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 134, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 134, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 134, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 135, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 135, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 135, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 135, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 135, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 135, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 135, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 135, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 135, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 135, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 136, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 136, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 136, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 136, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 136, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 136, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 136, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 136, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 136, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 136, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 136, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 136, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 136, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 137, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 137, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 137, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 137, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 137, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 137, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 137, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 137, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 137, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 137, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 137, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 138, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 138, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 138, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 138, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 138, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 138, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 138, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 138, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 138, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 138, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 139, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 139, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 139, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 139, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 139, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 139, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 139, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 139, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 139, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 139, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 139, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 140, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 140, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 140, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 140, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 140, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 140, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 140, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 140, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 140, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 140, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 140, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 140, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 141, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 141, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 141, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 141, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 141, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 141, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 141, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 141, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 141, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 141, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 142, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 142, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 142, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 142, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 142, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 142, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 142, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 142, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 143, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 143, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 143, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 143, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 143, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 143, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 143, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 143, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 143, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 143, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 143, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 144, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 144, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 144, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 144, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 144, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 144, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 144, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 144, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 144, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 144, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 145, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 145, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 145, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 145, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 145, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 145, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 145, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 145, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 145, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 145, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 145, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 145, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 145, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 146, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 146, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 146, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 146, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 146, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 146, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 146, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 146, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 146, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 146, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 146, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 146, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 147, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 147, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 147, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 147, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 147, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 147, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 147, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 147, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 147, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 148, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 148, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 148, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 148, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 148, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 148, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 148, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 148, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 148, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 148, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 148, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 148, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 149, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 149, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 149, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 149, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 149, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 149, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 149, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 149, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 149, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 149, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 149, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 149, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 150, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 150, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 150, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 150, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 150, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 150, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 150, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 150, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 150, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 150, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 150, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 150, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 150, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 151, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 151, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 151, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 151, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 151, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 151, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 151, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 151, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 151, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 151, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 152, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 152, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 152, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 152, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 152, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 152, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 152, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 152, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 152, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 153, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 153, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 153, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 153, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 153, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 153, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 153, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 153, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 153, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 153, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 153, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 153, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 154, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 154, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 154, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 154, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 154, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 154, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 154, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 154, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 154, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 154, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 155, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 155, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 155, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 155, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 155, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 155, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 155, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 155, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 155, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 155, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 155, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 155, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 156, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 156, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 156, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 156, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 156, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 156, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 156, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 157, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 157, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 157, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 157, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 157, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 157, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 157, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 157, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 157, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 157, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 157, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 158, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 158, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 158, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 158, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 158, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 158, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 158, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 158, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 158, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 158, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 158, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 158, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 158, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 159, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 159, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 159, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 159, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 159, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 159, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 159, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 159, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 159, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 159, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 160, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 160, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 160, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 160, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 160, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 160, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 160, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 160, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 160, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 160, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 160, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 160, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 161, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 161, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 161, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 161, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 161, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 161, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 161, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 161, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 161, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 161, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 161, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 161, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 161, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 161, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 162, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 162, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 162, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 162, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 162, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 162, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 162, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 162, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 162, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 162, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 162, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 163, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 163, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 163, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 163, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 163, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 163, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 163, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 163, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 163, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 163, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 163, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 163, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 164, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 164, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 164, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 164, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 164, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 164, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 164, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 164, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 164, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 164, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 164, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 164, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 164, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 164, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 165, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 165, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 165, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 165, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 165, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 165, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 165, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 165, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 165, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 165, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 165, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 165, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 166, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 166, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 166, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 166, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 166, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 166, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 166, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 166, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 166, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 166, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 166, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 166, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 166, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 167, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 167, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 167, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 167, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 167, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 167, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 167, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 167, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 167, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 167, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 167, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 167, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 168, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 168, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 168, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 168, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 168, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 168, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 168, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 168, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 168, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 168, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 169, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 169, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 169, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 169, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 169, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 169, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 169, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 169, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 169, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 169, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 169, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 169, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 170, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 170, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 170, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 170, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 170, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 170, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 170, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 170, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 170, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 170, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 170, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 170, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 171, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 171, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 171, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 171, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 171, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 171, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 171, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 171, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 171, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 171, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 171, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 172, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 172, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 172, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 172, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 172, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 172, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 172, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 172, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 172, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 172, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 173, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 173, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 173, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 173, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 173, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 173, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 173, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 173, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 173, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 173, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 173, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 173, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 173, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 174, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 174, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 174, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 174, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 174, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 174, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 174, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 174, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 174, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 174, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 174, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 174, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 175, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 175, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 175, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 175, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 175, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 175, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 175, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 175, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 175, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 175, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 176, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 176, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 176, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 176, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 176, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 176, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 176, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 176, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 176, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 176, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 176, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 176, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 177, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 177, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 177, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 177, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 177, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 177, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 177, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 177, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 177, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 177, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 177, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 177, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 178, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 178, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 178, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 178, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 178, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 178, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 178, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 178, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 178, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 178, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 179, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 179, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 179, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 179, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 179, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 179, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 179, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 179, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 179, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 179, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 179, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 179, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 180, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 180, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 180, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 180, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 180, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 180, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 180, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 180, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 180, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 180, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 181, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 181, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 181, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 181, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 181, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 181, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 181, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 181, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 181, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 181, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 181, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 181, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 181, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 182, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 182, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 182, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 182, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 182, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 182, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 182, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 182, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 182, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 182, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 182, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 182, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 182, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 182, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 183, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 183, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 183, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 183, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 183, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 183, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 183, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 183, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 183, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 183, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 183, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 183, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 184, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 184, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 184, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 184, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 184, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 184, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 184, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 184, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 184, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 185, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 185, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 185, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 185, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 185, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 185, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 185, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 185, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 185, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 185, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 185, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 185, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 186, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 186, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 186, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 186, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 186, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 186, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 186, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 186, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 186, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 186, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 186, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 187, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 187, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 187, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 187, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 187, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 187, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 187, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 187, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 188, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 188, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 188, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 188, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 188, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 188, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 188, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 188, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 188, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 188, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 188, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 188, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 189, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 189, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 189, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 189, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 189, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 189, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 189, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 189, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 189, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 190, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 190, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 190, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 190, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 190, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 190, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 190, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 190, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 190, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 190, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 191, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 191, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 191, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 191, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 191, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 191, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 191, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 191, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 191, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 191, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 191, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 191, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 192, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 192, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 192, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 192, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 192, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 192, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 192, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 192, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 193, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 193, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 193, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 193, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 193, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 193, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 193, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 193, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 193, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 193, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 193, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 194, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 194, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 194, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 194, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 194, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 194, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 194, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 194, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 194, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 194, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 194, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 194, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 194, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 195, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 195, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 195, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 195, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 195, 6 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 195, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 195, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 195, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 195, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 195, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 195, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 195, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 196, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 196, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 196, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 196, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 196, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 196, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 196, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 196, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 196, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 196, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 196, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 196, 15 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 197, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 197, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 197, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 197, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 197, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 197, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 197, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 197, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 197, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 198, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 198, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 198, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 198, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 198, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 198, 10 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 198, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 198, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 198, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 198, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 199, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 199, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 199, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 199, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 199, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 199, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 199, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 199, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 200, 1 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 200, 2 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 200, 3 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 200, 4 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 200, 5 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 200, 7 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 200, 8 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 200, 9 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 200, 11 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 200, 12 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 200, 13 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 200, 14 });

            migrationBuilder.DeleteData(
                table: "IngredientNutrients",
                keyColumns: new[] { "IngredientId", "NutrientId" },
                keyValues: new object[] { 200, 15 });

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Units",
                newName: "UnitName");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Units",
                newName: "Abbreviation");

            migrationBuilder.AddColumn<int>(
                name: "ActivityLevelId",
                table: "Users",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Users",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Bio",
                table: "Users",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "GenderId",
                table: "Users",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GoalId",
                table: "Users",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "HeightCm",
                table: "Users",
                type: "numeric(18,4)",
                precision: 18,
                scale: 4,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "WeightKg",
                table: "Users",
                type: "numeric(18,4)",
                precision: 18,
                scale: 4,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ConversionToBaseUnit",
                table: "Units",
                type: "numeric(18,4)",
                precision: 18,
                scale: 4,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "UnitId",
                table: "Ingredients",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ActivityLevels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityLevels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Goals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Goals", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ActivityLevels",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Little or no exercise", "Sedentary" },
                    { 2, "Light exercise/sports 1-3 days/week", "Light" },
                    { 3, "Moderate exercise/sports 3-5 days/week", "Moderate" },
                    { 4, "Hard exercise/sports 6-7 days/week", "Active" },
                    { 5, "Very hard exercise/sports & physical job or training twice per day", "Very Active" }
                });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Male gender", "Male" },
                    { 2, "Female gender", "Female" },
                    { 3, "Other gender identity", "Other" }
                });

            migrationBuilder.InsertData(
                table: "Goals",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Goal to lose weight", "Weight Loss" },
                    { 2, "Goal to maintain current weight", "Maintenance" },
                    { 3, "Goal to gain muscle mass", "Muscle Gain" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_ActivityLevelId",
                table: "Users",
                column: "ActivityLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_GenderId",
                table: "Users",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_GoalId",
                table: "Users",
                column: "GoalId");

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_UnitId",
                table: "Ingredients",
                column: "UnitId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredients_Units_UnitId",
                table: "Ingredients",
                column: "UnitId",
                principalTable: "Units",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_ActivityLevels_ActivityLevelId",
                table: "Users",
                column: "ActivityLevelId",
                principalTable: "ActivityLevels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Genders_GenderId",
                table: "Users",
                column: "GenderId",
                principalTable: "Genders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Goals_GoalId",
                table: "Users",
                column: "GoalId",
                principalTable: "Goals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
