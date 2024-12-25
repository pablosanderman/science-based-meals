using Microsoft.EntityFrameworkCore;

namespace ScienceBasedMealsApi.Models
{
    public class ApiDbContext(DbContextOptions option) : DbContext(option)
    {
        public required DbSet<User> Users { get; set; }
        public required DbSet<Gender> Genders { get; set; }
        public required DbSet<ActivityLevel> ActivityLevels { get; set; }
        public required DbSet<Goal> Goals { get; set; }
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
                .HasKey(idp => new { idp.IngredientId, idp.DietaryId });

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

            modelBuilder.Entity<MealLike>()
                .HasIndex(ml => new { ml.Id, ml.UserId })
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
                 .ToTable(t => t.HasCheckConstraint("CK_UserConnection_SelfFollow", "[FollowerUserId] <> [FollowedUserId]"));


            // Configure relationships
            modelBuilder.Entity<User>()
                .HasOne(u => u.Gender)
                .WithMany(g => g.Users)
                .HasForeignKey(u => u.GenderId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<User>()
                .HasOne(u => u.ActivityLevel)
                .WithMany(a => a.Users)
                .HasForeignKey(u => u.Id)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<User>()
                .HasOne(u => u.Goal)
                .WithMany(g => g.Users)
                .HasForeignKey(u => u.Id)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<User>()
                .HasOne(u => u.Role)
                .WithMany(r => r.Users)
                .HasForeignKey(u => u.Id)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<UserDietaryPreference>()
                .HasOne(udp => udp.User)
                .WithMany(u => u.UserDietaryPreferences)
                .HasForeignKey(udp => udp.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<UserDietaryPreference>()
                .HasOne(udp => udp.DietaryPreference)
                .WithMany(dp => dp.UserDietaryPreferences)
                .HasForeignKey(udp => udp.DietaryId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Ingredient>()
                .HasOne(i => i.DefaultUnit)
                .WithMany(u => u.Ingredients)
                .HasForeignKey(i => i.DefaultId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Nutrient>()
                .HasOne(n => n.Unit)
                .WithMany(u => u.Nutrients)
                .HasForeignKey(n => n.Id)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<IngredientNutrient>()
                .HasOne(inu => inu.Ingredient)
                .WithMany(i => i.IngredientNutrients)
                .HasForeignKey(inu => inu.Id)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<IngredientNutrient>()
                .HasOne(inu => inu.Nutrient)
                .WithMany(n => n.IngredientNutrients)
                .HasForeignKey(inu => inu.Id)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<MealVersion>()
                .HasOne(mv => mv.Meal)
                .WithMany(m => m.MealVersions)
                .HasForeignKey(mv => mv.Id)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<MealVersion>()
                .HasOne(mv => mv.CreatorUser)
                .WithMany(u => u.MealVersionsCreated)
                .HasForeignKey(mv => mv.CreatorUserId)
                .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<MealVersionIngredient>()
                .HasOne(mi => mi.MealVersion)
                .WithMany(mv => mv.MealIngredients)
                .HasForeignKey(mi => mi.Id)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<MealVersionIngredient>()
                .HasOne(mi => mi.Ingredient)
                .WithMany(i => i.MealIngredients)
                .HasForeignKey(mi => mi.Id)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<MealApproval>()
                .HasOne(ma => ma.MealVersion)
                .WithMany(mv => mv.MealApprovals)
                .HasForeignKey(ma => ma.Id)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<MealApproval>()
                .HasOne(ma => ma.ReviewerUser)
                .WithMany(u => u.MealApprovals)
                .HasForeignKey(ma => ma.ReviewerUserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<MealComment>()
                .HasOne(mc => mc.MealVersion)
                .WithMany(mv => mv.MealComments)
                .HasForeignKey(mc => mc.Id)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<MealComment>()
                .HasOne(mc => mc.User)
                .WithMany(u => u.MealComments)
                .HasForeignKey(mc => mc.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<MealComment>()
                .HasOne(mc => mc.ParentComment)
                .WithMany(mc => mc.Replies)
                .HasForeignKey(mc => mc.ParentCommentId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<MealLike>()
                .HasOne(ml => ml.MealVersion)
                .WithMany(mv => mv.MealLikes)
                .HasForeignKey(ml => ml.Id)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<MealLike>()
                .HasOne(ml => ml.User)
                .WithMany(u => u.MealLikes)
                .HasForeignKey(ml => ml.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Notification>()
                .HasOne(n => n.User)
                .WithMany(u => u.Notifications)
                .HasForeignKey(n => n.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Notification>()
                .HasOne(n => n.NotificationType)
                .WithMany(nt => nt.Notifications)
                .HasForeignKey(n => n.Id)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ResearchReferenceAuthor>()
                .HasOne(rra => rra.ResearchReference)
                .WithMany(rr => rr.ResearchReferenceAuthors)
                .HasForeignKey(rra => rra.ReferenceId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ResearchReferenceAuthor>()
                .HasOne(rra => rra.Author)
                .WithMany(a => a.ResearchReferenceAuthors)
                .HasForeignKey(rra => rra.AuthorId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<MealVersionResearchReference>()
                .HasOne(mvrr => mvrr.MealVersion)
                .WithMany(mv => mv.MealVersionResearchReferences)
                .HasForeignKey(mvrr => mvrr.Id)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<MealVersionResearchReference>()
                .HasOne(mvrr => mvrr.ResearchReference)
                .WithMany(rr => rr.MealVersionResearchReferences)
                .HasForeignKey(mvrr => mvrr.ReferenceId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<IngredientResearchReference>()
                .HasOne(irr => irr.Ingredient)
                .WithMany(i => i.IngredientResearchReferences)
                .HasForeignKey(irr => irr.Id)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<IngredientResearchReference>()
                .HasOne(irr => irr.ResearchReference)
                .WithMany(rr => rr.IngredientResearchReferences)
                .HasForeignKey(irr => irr.ReferenceId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<UserMeal>()
                .HasOne(sm => sm.User)
                .WithMany(u => u.SavedMeals)
                .HasForeignKey(sm => sm.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<UserMeal>()
                .HasOne(sm => sm.Meal)
                .WithMany(m => m.SavedMeals)
                .HasForeignKey(sm => sm.Id)
                .OnDelete(DeleteBehavior.Cascade);

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

            modelBuilder.Entity<IngredientDietaryPreference>()
                .HasOne(idp => idp.Ingredient)
                .WithMany(i => i.IngredientDietaryPreferences)
                .HasForeignKey(idp => idp.Id)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<IngredientDietaryPreference>()
                .HasOne(idp => idp.DietaryPreference)
                .WithMany(dp => dp.IngredientDietaryPreferences)
                .HasForeignKey(idp => idp.DietaryId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Meal>()
                .HasMany(m => m.MealVersions)
                .WithOne(mv => mv.Meal)
                .HasForeignKey(mv => mv.Id)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ResearchReference>()
                .HasMany(rr => rr.ResearchReferenceAuthors)
                .WithOne(rra => rra.ResearchReference)
                .HasForeignKey(rra => rra.ReferenceId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Author>()
                .HasMany(a => a.ResearchReferenceAuthors)
                .WithOne(rra => rra.Author)
                .HasForeignKey(rra => rra.AuthorId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<NotificationType>()
                .HasMany(nt => nt.Notifications)
                .WithOne(n => n.NotificationType)
                .HasForeignKey(n => n.Id)
                .OnDelete(DeleteBehavior.Restrict);


            // Seed data
            modelBuilder.Entity<User>().HasData(
                new { Id = 1, Username = "admin", Email = "admin@gmail.com", PasswordHash = "password", Bio = "Admin user", JoinDate = DateTime.Now, LastLogin = DateTime.Now, Age = 30, HeightCm = 180, WeightKg = 80, GenderId = 1, ActivityLevelId = 3, GoalId = 2, RoleId = 3 },
                new { Id = 2, Username = "reviewer", Email = "reviewer@gmail.com", PasswordHash = "password", Bio = "Reviewer user", JoinDate = DateTime.Now, LastLogin = DateTime.Now, Age = 28, HeightCm = 170, WeightKg = 70, GenderId = 2, ActivityLevelId = 2, GoalId = 1, RoleId = 2 },
                new { Id = 3, Username = "user", Email = "user@gmail.com", PasswordHash = "password", Bio = "Regular user", JoinDate = DateTime.Now, LastLogin = DateTime.Now, Age = 25, HeightCm = 160, WeightKg = 60, GenderId = 3, ActivityLevelId = 1, GoalId = 3, RoleId = 1 }
            );

            modelBuilder.Entity<Gender>().HasData(
                new Gender { Id = 1, Name = "Male", Description = "Male gender" },
                new Gender { Id = 2, Name = "Female", Description = "Female gender" },
                new Gender { Id = 3, Name = "Non-binary", Description = "Non-binary gender" },
                new Gender { Id = 4, Name = "Other", Description = "Other gender identities" }
            );

            modelBuilder.Entity<ActivityLevel>().HasData(
                new ActivityLevel { Id = 1, Name = "Sedentary", Description = "Little or no exercise" },
                new ActivityLevel { Id = 2, Name = "Lightly Active", Description = "Light exercise/sports 1-3 days/week" },
                new ActivityLevel { Id = 3, Name = "Moderately Active", Description = "Moderate exercise/sports 3-5 days/week" },
                new ActivityLevel { Id = 4, Name = "Very Active", Description = "Hard exercise/sports 6-7 days a week" },
                new ActivityLevel { Id = 5, Name = "Extra Active", Description = "Very hard exercise & physical job" }
            );

            modelBuilder.Entity<Goal>().HasData(
                new Goal { Id = 1, Name = "Weight Loss", Description = "Lose weight" },
                new Goal { Id = 2, Name = "Maintenance", Description = "Maintain current weight" },
                new Goal { Id = 3, Name = "Weight Gain", Description = "Gain weight" }
            );

            modelBuilder.Entity<Role>().HasData(
                new Role { Id = 1, Name = "User" },
                new Role { Id = 2, Name = "Reviewer" },
                new Role { Id = 3, Name = "Admin" }
            );

            modelBuilder.Entity<NotificationType>().HasData(
                new NotificationType { Id = 1, Name = "Comment", Description = "New comment on your meal" },
                new NotificationType { Id = 2, Name = "Like", Description = "Someone liked your meal" },
                new NotificationType { Id = 3, Name = "Follow", Description = "Someone followed you" }
            );

            modelBuilder.Entity<DietaryPreference>().HasData(
                new DietaryPreference { Id = 1, Name = "Vegetarian", Description = "Excludes meat and fish products." },
                new DietaryPreference { Id = 2, Name = "Vegan", Description = "Excludes all animal products, including dairy and eggs." },
                new DietaryPreference { Id = 3, Name = "Gluten-Free", Description = "Excludes gluten-containing grains like wheat, barley, and rye." },
                new DietaryPreference { Id = 4, Name = "Dairy-Free", Description = "Excludes milk and dairy products." },
                new DietaryPreference { Id = 5, Name = "Nut-Free", Description = "Excludes nuts and products containing nuts." },
                new DietaryPreference { Id = 6, Name = "Shellfish-Free", Description = "Excludes shellfish and mollusks." },
                new DietaryPreference { Id = 7, Name = "Halal", Description = "Permissible foods under Islamic law." },
                new DietaryPreference { Id = 8, Name = "Kosher", Description = "Foods that comply with Jewish dietary laws." },
                new DietaryPreference { Id = 9, Name = "Pescatarian", Description = "Vegetarian diet that includes fish." },
                new DietaryPreference { Id = 10, Name = "Low-Carb", Description = "Diet low in carbohydrates." },
                new DietaryPreference { Id = 11, Name = "Low-Fat", Description = "Diet low in fat content." },
                new DietaryPreference { Id = 12, Name = "Paleo", Description = "Focuses on whole foods presumed to be available to Paleolithic humans." },
                new DietaryPreference { Id = 13, Name = "Ketogenic (Keto)", Description = "High-fat, adequate-protein, low-carbohydrate diet." },
                new DietaryPreference { Id = 14, Name = "Diabetic-Friendly", Description = "Suitable for individuals managing blood sugar levels." },
                new DietaryPreference { Id = 15, Name = "High-Protein", Description = "Diet high in protein, often for muscle building." },
                new DietaryPreference { Id = 16, Name = "Low-Sodium", Description = "Diet low in salt." },
                new DietaryPreference { Id = 17, Name = "Lactose-Free", Description = "Excludes lactose-containing dairy products." },
                new DietaryPreference { Id = 18, Name = "Egg-Free", Description = "Excludes eggs and egg products." },
                new DietaryPreference { Id = 19, Name = "Soy-Free", Description = "Excludes soy and soy products." },
                new DietaryPreference { Id = 20, Name = "FODMAP-Friendly", Description = "Suitable for those following a low-FODMAP diet to manage IBS." },
                new DietaryPreference { Id = 21, Name = "Organic", Description = "Foods produced without synthetic pesticides or fertilizers." },
                new DietaryPreference { Id = 22, Name = "Raw Food", Description = "Consists of unprocessed and uncooked foods." },
                new DietaryPreference { Id = 23, Name = "No Added Sugar", Description = "Excludes foods with added sugars." },
                new DietaryPreference { Id = 24, Name = "Vegetarian (Ovo-Lacto)", Description = "Vegetarian diet that includes dairy and eggs." },
                new DietaryPreference { Id = 25, Name = "Pescatarian", Description = "Includes fish but excludes other meats." }
            );

            modelBuilder.Entity<Meal>().HasData(
                new Meal { Id = 1, Name = "Grilled Chicken with Rice and Broccoli", Description = "A healthy meal of grilled chicken breast served with steamed rice and broccoli.", CreationDate = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new Meal { Id = 2, Name = "Oatmeal with Banana and Almonds", Description = "A hearty breakfast of oatmeal topped with sliced banana and almonds.", CreationDate = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new Meal { Id = 3, Name = "Scrambled Eggs with Toast", Description = "Classic scrambled eggs served with buttered toast.", CreationDate = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }
            );

            modelBuilder.Entity<MealVersion>().HasData(
                new { Id = 1, MealId = 1, VersionNumber = 1, CreatorUserId = 1, Description = "Initial version of Grilled Chicken meal.", CreationDate = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new { Id = 2, MealId = 2, VersionNumber = 1, CreatorUserId = 1, Description = "Initial version of Oatmeal breakfast.", CreationDate = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new { Id = 3, MealId = 3, VersionNumber = 1, CreatorUserId = 1, Description = "Initial version of Scrambled Eggs meal.", CreationDate = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }
            );

            modelBuilder.Entity<MealVersionIngredient>().HasData(
                // Meal 1: Grilled Chicken with Rice and Broccoli
                new { MealVersionId = 1, IngredientId = 1, Quantity = 200m, UnitId = 1 }, // 200g Chicken Breast
                new { MealVersionId = 1, IngredientId = 2, Quantity = 150m, UnitId = 1 }, // 150g Rice
                new { MealVersionId = 1, IngredientId = 3, Quantity = 100m, UnitId = 1 }, // 100g Broccoli
                new { MealVersionId = 1, IngredientId = 4, Quantity = 10m, UnitId = 5 },  // 10ml Olive Oil
                new { MealVersionId = 1, IngredientId = 5, Quantity = 1m, UnitId = 1 },   // 1g Salt

                // Meal 2: Oatmeal with Banana and Almonds
                new { MealVersionId = 2, IngredientId = 9, Quantity = 50m, UnitId = 1 },   // 50g Oats
                new { MealVersionId = 2, IngredientId = 7, Quantity = 200m, UnitId = 5 },  // 200ml Milk
                new { MealVersionId = 2, IngredientId = 8, Quantity = 100m, UnitId = 1 },  // 100g Banana
                new { MealVersionId = 2, IngredientId = 10, Quantity = 15m, UnitId = 1 },  // 15g Almonds

                // Meal 3: Scrambled Eggs with Toast
                new { MealVersionId = 3, IngredientId = 6, Quantity = 2m, UnitId = 6 },    // 2 Eggs
                new { MealVersionId = 3, IngredientId = 4, Quantity = 5m, UnitId = 5 },    // 5ml Olive Oil
                new { MealVersionId = 3, IngredientId = 11, Quantity = 2m, UnitId = 6 }    // 2 Slices of Bread (Assuming IngredientId = 11)
            );


            modelBuilder.Entity<Ingredient>().HasData(
                new { Id = 1, Name = "Chicken Breast", Description = "Boneless, skinless chicken breast", DefaultUnitId = 1, UpdatedAt = DateTime.UtcNow },
                new { Id = 2, Name = "Rice", Description = "White rice, long-grain, cooked", DefaultUnitId = 1, UpdatedAt = DateTime.UtcNow },
                new { Id = 3, Name = "Broccoli", Description = "Fresh broccoli florets", DefaultUnitId = 1, UpdatedAt = DateTime.UtcNow },
                new { Id = 4, Name = "Olive Oil", Description = "Extra virgin olive oil", DefaultUnitId = 5, UpdatedAt = DateTime.UtcNow },
                new { Id = 5, Name = "Salt", Description = "Table salt", DefaultUnitId = 1, UpdatedAt = DateTime.UtcNow },
                new { Id = 6, Name = "Egg", Description = "Whole chicken egg, raw", DefaultUnitId = 6, UpdatedAt = DateTime.UtcNow },
                new { Id = 7, Name = "Milk", Description = "Whole milk", DefaultUnitId = 5, UpdatedAt = DateTime.UtcNow },
                new { Id = 8, Name = "Banana", Description = "Raw banana", DefaultUnitId = 1, UpdatedAt = DateTime.UtcNow },
                new { Id = 9, Name = "Oats", Description = "Rolled oats, dry", DefaultUnitId = 1, UpdatedAt = DateTime.UtcNow },
                new { Id = 10, Name = "Almonds", Description = "Raw almonds", DefaultUnitId = 1, UpdatedAt = DateTime.UtcNow },
                new { Id = 11, Name = "Bread", Description = "Slice of wholegrain bread", DefaultUnitId = 6, UpdatedAt = DateTime.UtcNow }
            );

            modelBuilder.Entity<Unit>().HasData(
                new Unit { Id = 1, UnitName = "Gram", Abbreviation = "g", ConversionToBaseUnit = 1m },
                new Unit { Id = 2, UnitName = "Kilogram", Abbreviation = "kg", ConversionToBaseUnit = 1000m },
                new Unit { Id = 3, UnitName = "Milligram", Abbreviation = "mg", ConversionToBaseUnit = 0.001m },
                new Unit { Id = 4, UnitName = "Liter", Abbreviation = "l", ConversionToBaseUnit = 1000m },
                new Unit { Id = 5, UnitName = "Milliliter", Abbreviation = "ml", ConversionToBaseUnit = 1m },
                new Unit { Id = 6, UnitName = "Piece", Abbreviation = "pcs", ConversionToBaseUnit = 1m } // For items like eggs
            );

            modelBuilder.Entity<Nutrient>().HasData(
                new { Id = 1, Name = "Calories", UnitId = 1, DailyValue = 2000 },
                new { Id = 2, Name = "Protein", UnitId = 1, DailyValue = 50 },
                new { Id = 3, Name = "Fat", UnitId = 1, DailyValue = 70 },
                new { Id = 4, Name = "Carbohydrates", UnitId = 1, DailyValue = 260 },
                new { Id = 5, Name = "Fiber", UnitId = 1, DailyValue = 30 },
                new { Id = 6, Name = "Sugar", UnitId = 1, DailyValue = 90 },
                new { Id = 7, Name = "Sodium", UnitId = 3, DailyValue = 2400 }
            );

            modelBuilder.Entity<IngredientNutrient>().HasData(
                // Chicken Breast
                new { IngredientId = 1, NutrientId = 1, Amount = 165m },
                new { IngredientId = 1, NutrientId = 2, Amount = 31m },
                new { IngredientId = 1, NutrientId = 3, Amount = 3.6m },
                new { IngredientId = 1, NutrientId = 4, Amount = 0m },

                // Rice
                new { IngredientId = 2, NutrientId = 1, Amount = 130m },
                new { IngredientId = 2, NutrientId = 2, Amount = 2.4m },
                new { IngredientId = 2, NutrientId = 3, Amount = 0.3m },
                new { IngredientId = 2, NutrientId = 4, Amount = 28m },
                new { IngredientId = 2, NutrientId = 5, Amount = 0.4m },

                // Broccoli
                new { IngredientId = 3, NutrientId = 1, Amount = 55m },
                new { IngredientId = 3, NutrientId = 2, Amount = 3.7m },
                new { IngredientId = 3, NutrientId = 3, Amount = 0.6m },
                new { IngredientId = 3, NutrientId = 4, Amount = 11m },
                new { IngredientId = 3, NutrientId = 5, Amount = 3.3m },

                // Olive Oil
                new { IngredientId = 4, NutrientId = 1, Amount = 884m },
                new { IngredientId = 4, NutrientId = 3, Amount = 100m },

                // Salt
                new { IngredientId = 5, NutrientId = 7, Amount = 38758m }, // Sodium in mg per 100g

                // Egg
                new { IngredientId = 6, NutrientId = 1, Amount = 155m },
                new { IngredientId = 6, NutrientId = 2, Amount = 13m },
                new { IngredientId = 6, NutrientId = 3, Amount = 11m },
                new { IngredientId = 6, NutrientId = 4, Amount = 1.1m },

                // Milk
                new { IngredientId = 7, NutrientId = 1, Amount = 42m },
                new { IngredientId = 7, NutrientId = 2, Amount = 3.4m },
                new { IngredientId = 7, NutrientId = 3, Amount = 1m },
                new { IngredientId = 7, NutrientId = 4, Amount = 5m },

                // Banana
                new { IngredientId = 8, NutrientId = 1, Amount = 89m },
                new { IngredientId = 8, NutrientId = 2, Amount = 1.1m },
                new { IngredientId = 8, NutrientId = 3, Amount = 0.3m },
                new { IngredientId = 8, NutrientId = 4, Amount = 23m },
                new { IngredientId = 8, NutrientId = 5, Amount = 2.6m },
                new { IngredientId = 8, NutrientId = 6, Amount = 12m },

                // Oats
                new { IngredientId = 9, NutrientId = 1, Amount = 389m },
                new { IngredientId = 9, NutrientId = 2, Amount = 16.9m },
                new { IngredientId = 9, NutrientId = 3, Amount = 6.9m },
                new { IngredientId = 9, NutrientId = 4, Amount = 66m },
                new { IngredientId = 9, NutrientId = 5, Amount = 10.6m },

                // Almonds
                new { IngredientId = 10, NutrientId = 1, Amount = 579m },
                new { IngredientId = 10, NutrientId = 2, Amount = 21m },
                new { IngredientId = 10, NutrientId = 3, Amount = 50m },
                new { IngredientId = 10, NutrientId = 4, Amount = 22m },
                new { IngredientId = 10, NutrientId = 5, Amount = 12.5m },

                // Bread
                new { IngredientId = 11, NutrientId = 1, Amount = 265m },
                new { IngredientId = 11, NutrientId = 2, Amount = 9m },
                new { IngredientId = 11, NutrientId = 3, Amount = 3.2m },
                new { IngredientId = 11, NutrientId = 4, Amount = 49m },
                new { IngredientId = 11, NutrientId = 5, Amount = 2.7m }
            );
        }
    }
}