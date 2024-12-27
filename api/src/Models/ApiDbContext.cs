using Microsoft.EntityFrameworkCore;

namespace ScienceBasedMealsApi.Models
{
	public class ApiDbContext(DbContextOptions option) : DbContext(option)
	{
		public required DbSet<User> Users { get; set; }
		public required DbSet<DietaryPreference> DietaryPreferences { get; set; }
		public required DbSet<UserDietaryPreference> UserDietaryPreferences { get; set; }
		public required DbSet<Ingredient> Ingredients { get; set; }
		public required DbSet<Unit> Units { get; set; }
		public required DbSet<Nutrient> Nutrients { get; set; }
		public required DbSet<IngredientNutrient> IngredientNutrients { get; set; }
		public required DbSet<Meal> Meals { get; set; }
		public required DbSet<MealVersion> MealVersions { get; set; }
		public required DbSet<MealVersionIngredient> MealVersionIngredients { get; set; }
		public required DbSet<ResearchReference> ResearchReferences { get; set; }
		public required DbSet<Author> Authors { get; set; }
		public required DbSet<ResearchReferenceAuthor> ResearchReferenceAuthors { get; set; }
		public required DbSet<MealVersionResearchReference> MealVersionResearchReferences { get; set; }
		public required DbSet<IngredientResearchReference> IngredientResearchReferences { get; set; }
		public required DbSet<UserMeal> SavedMeals { get; set; }
		public required DbSet<UserConnection> UserConnections { get; set; }
		public required DbSet<IngredientDietaryPreference> IngredientDietaryPreferences { get; set; }
		public required DbSet<Role> Roles { get; set; }
		public required DbSet<MealApproval> MealApprovals { get; set; }
		public required DbSet<MealComment> MealComments { get; set; }
		public required DbSet<MealLike> MealLikes { get; set; }
		public required DbSet<Notification> Notifications { get; set; }
		public required DbSet<NotificationType> NotificationTypes { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			// Seed initial data
			modelBuilder.Entity<Role>().HasData(
				new Role { Id = 1, Name = "User" },
				new Role { Id = 2, Name = "Moderator" },
				new Role { Id = 3, Name = "Admin" }
			);

			// Configure composite primary keys
			modelBuilder.Entity<UserDietaryPreference>()
				.HasKey(udp => new { udp.UserId, udp.DietaryPreferenceId });

			modelBuilder.Entity<IngredientNutrient>()
				.HasKey(inu => new { inu.IngredientId, inu.NutrientId });

			modelBuilder.Entity<MealVersionIngredient>()
				.HasKey(mi => new { mi.MealVersionId, mi.IngredientId });

			modelBuilder.Entity<ResearchReferenceAuthor>()
				.HasKey(rra => new { rra.ReferenceId, rra.AuthorId });

			modelBuilder.Entity<MealVersionResearchReference>()
				.HasKey(mvrr => new { mvrr.MealVersionId, mvrr.ReferenceId });

			modelBuilder.Entity<IngredientResearchReference>()
				.HasKey(irr => new { irr.IngredientId, irr.ReferenceId });

			modelBuilder.Entity<UserMeal>()
				.HasKey(sm => new { sm.UserId, sm.MealId });

			modelBuilder.Entity<UserConnection>()
				.HasKey(uc => new { uc.FollowerUserId, uc.FollowedUserId });

			modelBuilder.Entity<IngredientDietaryPreference>()
				.HasKey(idp => new { idp.IngredientId, idp.DietaryPreferenceId });

			// Configure unique indexes
			modelBuilder.Entity<User>()
				.HasIndex(u => u.Email)
				.IsUnique();

			modelBuilder.Entity<User>()
				.HasIndex(u => u.Username)
				.IsUnique();

			modelBuilder.Entity<NotificationType>()
				.HasIndex(nt => nt.Name)
				.IsUnique();

			// Configure indexes for performance
			modelBuilder.Entity<Meal>()
				.HasIndex(m => m.Name);

			modelBuilder.Entity<Ingredient>()
				.HasIndex(i => i.Name);

			modelBuilder.Entity<MealComment>()
				.HasIndex(mc => new { mc.Id, mc.ParentCommentId });

			// Configure check constraints
			modelBuilder.Entity<UserConnection>()
				 .ToTable(t => t.HasCheckConstraint("CK_UserConnection_SelfFollow", "\"FollowerUserId\" <> \"FollowedUserId\""));

			// Configure relationships
			modelBuilder.Entity<User>()
				.HasOne(u => u.Role)
				.WithMany(r => r.Users)
				.HasForeignKey(u => u.RoleId)
				.OnDelete(DeleteBehavior.Restrict);

			modelBuilder.Entity<UserDietaryPreference>()
				.HasOne(udp => udp.User)
				.WithMany(u => u.UserDietaryPreferences)
				.HasForeignKey(udp => udp.UserId)
				.OnDelete(DeleteBehavior.Cascade);

			modelBuilder.Entity<UserDietaryPreference>()
				.HasOne(udp => udp.DietaryPreference)
				.WithMany(dp => dp.UserDietaryPreferences)
				.HasForeignKey(udp => udp.DietaryPreferenceId)
				.OnDelete(DeleteBehavior.Cascade);

			modelBuilder.Entity<Nutrient>()
				.HasOne(n => n.Unit)
				.WithMany(u => u.Nutrients)
				.HasForeignKey(n => n.UnitId)
				.OnDelete(DeleteBehavior.Restrict);

			modelBuilder.Entity<IngredientNutrient>()
				.HasOne(inu => inu.Ingredient)
				.WithMany(i => i.Nutrients)
				.HasForeignKey(inu => inu.IngredientId)
				.OnDelete(DeleteBehavior.Cascade);

			modelBuilder.Entity<IngredientNutrient>()
				.HasOne(inu => inu.Nutrient)
				.WithMany(n => n.IngredientNutrients)
				.HasForeignKey(inu => inu.NutrientId)
				.OnDelete(DeleteBehavior.Cascade);

			modelBuilder.Entity<MealVersion>()
				.HasOne(mv => mv.Meal)
				.WithMany(m => m.MealVersions)
				.HasForeignKey(mv => mv.MealId)
				.OnDelete(DeleteBehavior.Cascade);

			modelBuilder.Entity<MealVersionIngredient>()
				.HasOne(mi => mi.MealVersion)
				.WithMany(mv => mv.Ingredients)
				.HasForeignKey(mi => mi.MealVersionId)
				.OnDelete(DeleteBehavior.Cascade);

			modelBuilder.Entity<MealVersionIngredient>()
				.HasOne(mi => mi.Ingredient)
				.WithMany(i => i.MealVersions)
				.HasForeignKey(mi => mi.IngredientId)
				.OnDelete(DeleteBehavior.Cascade);

			modelBuilder.Entity<MealVersionResearchReference>()
				.HasOne(mvrr => mvrr.MealVersion)
				.WithMany(mv => mv.ResearchReferences)
				.HasForeignKey(mvrr => mvrr.MealVersionId)
				.OnDelete(DeleteBehavior.Cascade);

			modelBuilder.Entity<MealVersionResearchReference>()
				.HasOne(mvrr => mvrr.ResearchReference)
				.WithMany(rr => rr.MealVersionResearchReferences)
				.HasForeignKey(mvrr => mvrr.ReferenceId)
				.OnDelete(DeleteBehavior.Cascade);

			modelBuilder.Entity<IngredientResearchReference>()
				.HasOne(irr => irr.Ingredient)
				.WithMany(i => i.ResearchReferences)
				.HasForeignKey(irr => irr.IngredientId)
				.OnDelete(DeleteBehavior.Cascade);

			modelBuilder.Entity<IngredientResearchReference>()
				.HasOne(irr => irr.ResearchReference)
				.WithMany(rr => rr.IngredientResearchReferences)
				.HasForeignKey(irr => irr.ReferenceId)
				.OnDelete(DeleteBehavior.Cascade);

			modelBuilder.Entity<IngredientDietaryPreference>()
				.HasOne(idp => idp.Ingredient)
				.WithMany(i => i.DietaryPreferences)
				.HasForeignKey(idp => idp.IngredientId)
				.OnDelete(DeleteBehavior.Cascade);

			modelBuilder.Entity<IngredientDietaryPreference>()
				.HasOne(idp => idp.DietaryPreference)
				.WithMany(dp => dp.IngredientDietaryPreferences)
				.HasForeignKey(idp => idp.DietaryPreferenceId)
				.OnDelete(DeleteBehavior.Cascade);

			// Configure User follow relationships
			modelBuilder.Entity<UserConnection>()
				.HasOne(uc => uc.FollowerUser)
				.WithMany(u => u.Following)
				.HasForeignKey(uc => uc.FollowerUserId)
				.OnDelete(DeleteBehavior.Restrict);

			modelBuilder.Entity<UserConnection>()
				.HasOne(uc => uc.FollowedUser)
				.WithMany(u => u.Followers)
				.HasForeignKey(uc => uc.FollowedUserId)
				.OnDelete(DeleteBehavior.Restrict);
		}
	}
}
