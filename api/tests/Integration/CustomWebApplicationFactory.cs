using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using ScienceBasedMealsApi.Models;

namespace ScienceBasedMealsApi.Tests.Integration;

public class CustomWebApplicationFactory<TProgram> : WebApplicationFactory<TProgram> where TProgram : class
{
  protected override void ConfigureWebHost(IWebHostBuilder builder)
  {
    builder.ConfigureAppConfiguration((context, config) =>
    {
      var inMemorySettings = new Dictionary<string, string>
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
          db.Meals.Add(new Meal
          {
            Name = "Test Meal 1",
            Description = "Test Description 1",
            CreationDate = DateTime.UtcNow
          });

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