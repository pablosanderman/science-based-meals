using Microsoft.EntityFrameworkCore;
using ScienceBasedMealsApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Add CORS
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        if (builder.Environment.IsDevelopment())
        {
            policy.AllowAnyOrigin()
                  .AllowAnyHeader()
                  .AllowAnyMethod();
        }
        else
        {
            // In production, replace this with your actual frontend URL
            policy.WithOrigins("https://yourdomain.com")
                  .AllowAnyHeader()
                  .AllowAnyMethod();
        }
    });
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Title = "Science Based Meals API",
        Version = "v1",
        Description = "API for managing science-based meals"
    });
});

// Configure database context
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApiDbContext>(options =>
    options.UseNpgsql(connectionString));

var app = builder.Build();

// Initialize/Migrate Database
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<ApiDbContext>();
    try
    {
        // Check if database exists and create if it doesn't
        db.Database.EnsureCreated();

        // Check if we need to seed data
        if (!db.Genders.Any())
        {
            db.Genders.AddRange(
                new Gender { Id = 1, Name = "Male", Description = "Male gender" },
                new Gender { Id = 2, Name = "Female", Description = "Female gender" },
                new Gender { Id = 3, Name = "Other", Description = "Other gender identity" }
            );
        }

        if (!db.ActivityLevels.Any())
        {
            db.ActivityLevels.AddRange(
                new ActivityLevel { Id = 1, Name = "Sedentary", Description = "Little or no exercise" },
                new ActivityLevel { Id = 2, Name = "Light", Description = "Light exercise/sports 1-3 days/week" },
                new ActivityLevel { Id = 3, Name = "Moderate", Description = "Moderate exercise/sports 3-5 days/week" },
                new ActivityLevel { Id = 4, Name = "Active", Description = "Hard exercise/sports 6-7 days/week" },
                new ActivityLevel { Id = 5, Name = "Very Active", Description = "Very hard exercise/sports & physical job or training twice per day" }
            );
        }

        if (!db.Goals.Any())
        {
            db.Goals.AddRange(
                new Goal { Id = 1, Name = "Weight Loss", Description = "Goal to lose weight" },
                new Goal { Id = 2, Name = "Maintenance", Description = "Goal to maintain current weight" },
                new Goal { Id = 3, Name = "Muscle Gain", Description = "Goal to gain muscle mass" }
            );
        }

        if (!db.Roles.Any())
        {
            db.Roles.AddRange(
                new Role { Id = 1, Name = "User" },
                new Role { Id = 2, Name = "Moderator" },
                new Role { Id = 3, Name = "Admin" }
            );
        }

        db.SaveChanges();
    }
    catch (Exception ex)
    {
        var logger = scope.ServiceProvider.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "An error occurred while migrating or initializing the database.");
        throw;
    }
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Enable CORS
app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();

public partial class Program { }
