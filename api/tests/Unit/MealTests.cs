using FluentAssertions;
using ScienceBasedMealsApi.Models;
using Xunit;

namespace ScienceBasedMealsApi.Tests.Unit;

public class MealTests
{
	[Fact]
	public void Meal_WithValidProperties_ShouldBeCreated()
	{
		var user = new User
		{
			Email = "test@test.com",
			Username = "test",
			PasswordHash = "password",
		};

		// Arrange
		var meal = new Meal
		{
			Name = "Test Meal",
			Creator = user,
			CreationDate = DateTime.UtcNow
		};

		// Assert
		meal.Name.Should().Be("Test Meal");
		meal.CreationDate.Should().BeCloseTo(DateTime.UtcNow, TimeSpan.FromSeconds(1));
	}
}
