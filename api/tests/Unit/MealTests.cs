using FluentAssertions;
using ScienceBasedMealsApi.Models;
using Xunit;

namespace ScienceBasedMealsApi.Tests.Unit;

public class MealTests
{
	[Fact]
	public void Meal_WithValidProperties_ShouldBeCreated()
	{
		// Arrange
		var meal = new Meal
		{
			Name = "Test Meal",
			Description = "A test meal description",
			CreationDate = DateTime.UtcNow
		};

		// Assert
		meal.Name.Should().Be("Test Meal");
		meal.Description.Should().Be("A test meal description");
		meal.CreationDate.Should().BeCloseTo(DateTime.UtcNow, TimeSpan.FromSeconds(1));
	}
}
