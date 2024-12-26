using System.Net;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using ScienceBasedMealsApi.Models;
using Xunit;

namespace ScienceBasedMealsApi.Tests.Integration;

public class MealControllerTests : IClassFixture<CustomWebApplicationFactory<Program>>
{
	private readonly CustomWebApplicationFactory<Program> _factory;
	private readonly HttpClient _client;

	public MealControllerTests(CustomWebApplicationFactory<Program> factory)
	{
		_factory = factory;
		_client = factory.CreateClient(new WebApplicationFactoryClientOptions
		{
			AllowAutoRedirect = false
		});
	}

	[Fact]
	public async Task GetMeals_ReturnsSuccessStatusCode()
	{
		// Act
		var response = await _client.GetAsync("/api/meals");

		// Assert
		response.StatusCode.Should().Be(HttpStatusCode.OK);
	}
}
