using System.ComponentModel.DataAnnotations.Schema;

namespace ScienceBasedMealsApi.Models
{
    public class UserDietaryPreference
    {
        [ForeignKey("User")]
        public int UserId { get; set; }

        public required User User { get; set; }

        [ForeignKey("DietaryPreference")]
        public int DietaryPreferenceId { get; set; }

        public required DietaryPreference DietaryPreference { get; set; }
    }
}
