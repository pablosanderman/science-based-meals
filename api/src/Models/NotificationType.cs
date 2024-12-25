using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ScienceBasedMealsApi.Models
{
    public class NotificationType
    {
        [Key]
        public int Id { get; set; }  // notification_type_id

        [Required]
        public string Name { get; set; } = "";

        public string Description { get; set; } = "";

        public ICollection<Notification> Notifications { get; set; } = [];
    }
}
