using Microsoft.EntityFrameworkCore;
using ScienceBasedMealsApi.Models;

namespace ScienceBasedMealsApi.Data;

public static class UserSeedData
{
  public static void SeedUserData(this ModelBuilder modelBuilder)
  {
    SeedRoles(modelBuilder);
    SeedUsers(modelBuilder);
  }

  private static void SeedRoles(ModelBuilder modelBuilder)
  {
    modelBuilder.Entity<Role>().HasData(
        new Role { Id = 1, Name = "User" },
        new Role { Id = 2, Name = "Reviewer" },
        new Role { Id = 3, Name = "Admin" }
    );
  }

  private static void SeedUsers(ModelBuilder modelBuilder)
  {
    var baseDate = DateTime.UtcNow.Date;
    var users = new[]
    {
            // Admin
            new User
            {
                Id = 1,
                Username = "admin",
                Email = "admin@sciencemeals.com",
                PasswordHash = "hashed_password_123", // In real app, use proper password hashing
                RoleId = 3, // Admin
                JoinDate = baseDate,
                LastLogin = baseDate
            },
            // Moderators (Reviewers)
            new User
            {
                Id = 2,
                Username = "reviewer1",
                Email = "reviewer1@sciencemeals.com",
                PasswordHash = "hashed_password_123",
                RoleId = 2, // Moderator
                JoinDate = baseDate,
                LastLogin = baseDate
            },
            new User
            {
                Id = 3,
                Username = "reviewer2",
                Email = "reviewer2@sciencemeals.com",
                PasswordHash = "hashed_password_123",
                RoleId = 2, // Moderator
                JoinDate = baseDate,
                LastLogin = baseDate
            },
            // Regular users
            new User
            {
                Id = 4,
                Username = "foodie_scientist",
                Email = "foodie@example.com",
                PasswordHash = "hashed_password_123",
                RoleId = 1, // User
                JoinDate = baseDate,
                LastLogin = baseDate
            },
            new User
            {
                Id = 5,
                Username = "health_enthusiast",
                Email = "health@example.com",
                PasswordHash = "hashed_password_123",
                RoleId = 1,
                JoinDate = baseDate,
                LastLogin = baseDate
            },
            new User
            {
                Id = 6,
                Username = "nutrition_pro",
                Email = "nutrition@example.com",
                PasswordHash = "hashed_password_123",
                RoleId = 1,
                JoinDate = baseDate,
                LastLogin = baseDate
            },
            new User
            {
                Id = 7,
                Username = "meal_planner",
                Email = "planner@example.com",
                PasswordHash = "hashed_password_123",
                RoleId = 1,
                JoinDate = baseDate,
                LastLogin = baseDate
            },
            new User
            {
                Id = 8,
                Username = "wellness_coach",
                Email = "wellness@example.com",
                PasswordHash = "hashed_password_123",
                RoleId = 1,
                JoinDate = baseDate,
                LastLogin = baseDate
            },
            new User
            {
                Id = 9,
                Username = "fitness_foodie",
                Email = "fitness@example.com",
                PasswordHash = "hashed_password_123",
                RoleId = 1,
                JoinDate = baseDate,
                LastLogin = baseDate
            },
            new User
            {
                Id = 10,
                Username = "healthy_chef",
                Email = "chef@example.com",
                PasswordHash = "hashed_password_123",
                RoleId = 1,
                JoinDate = baseDate,
                LastLogin = baseDate
            }
        };

    modelBuilder.Entity<User>().HasData(users);
  }
}