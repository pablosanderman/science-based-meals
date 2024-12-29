using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ScienceBasedMealsApi.Models;

namespace ScienceBasedMealsApi.Tests.Integration;

public class CustomWebApplicationFactory<TProgram> : WebApplicationFactory<TProgram> where TProgram : class
{
	protected override void ConfigureWebHost(IWebHostBuilder builder)
	{
		builder.ConfigureAppConfiguration((context, config) =>
		{
			var inMemorySettings = new Dictionary<string, string?>
			{
				{"ConnectionStrings:DefaultConnection", "DataSource=:memory:"}
			};

			config.AddInMemoryCollection(inMemorySettings);
		});

		builder.ConfigureServices(services =>
		{
			var descriptor = services.SingleOrDefault(
				d => d.ServiceType == typeof(DbContextOptions<ApiDbContext>));

			if (descriptor != null)
			{
				services.Remove(descriptor);
			}

			services.AddDbContext<ApiDbContext>(options =>
			{
				options.UseInMemoryDatabase("TestingDb");
			});

			var sp = services.BuildServiceProvider();
			using var scope = sp.CreateScope();
			var db = scope.ServiceProvider.GetRequiredService<ApiDbContext>();

			try
			{
				db.Database.EnsureCreated();

				// Seed test data
				if (!db.Meals.Any())
				{
					var user = new User
					{
						Email = "test@test.com",
						Username = "test",
						PasswordHash = "password",
					};

					db.Users.Add(user);

					var meal = new Meal
					{
						Name = "Test Meal 1",
						Creator = user,
						CreationDate = DateTime.UtcNow
					};

					db.Meals.Add(meal);

					db.SaveChanges();
				}
			}
			catch (Exception)
			{
				// Log the error or handle it as needed
				throw;
			}
		});
	}
}
