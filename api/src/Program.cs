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
if (connectionString?.Contains(":memory:") == true)
{
    builder.Services.AddDbContext<ApiDbContext>(options =>
        options.UseInMemoryDatabase("TestingDb"));
}
else
{
    builder.Services.AddDbContext<ApiDbContext>(options =>
        options.UseNpgsql(connectionString));
}

var app = builder.Build();

// Apply migrations only if using PostgreSQL
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<ApiDbContext>();
    if (db.Database.ProviderName != "Microsoft.EntityFrameworkCore.InMemory")
    {
        db.Database.Migrate();
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
