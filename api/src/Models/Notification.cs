using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScienceBasedMealsApi.Models
{
    public class Notification
    {
        [Key]
        public int Id { get; set; }  // notification_id

        [Required]
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User? User { get; set; }

        [Required]
        public int NotificationTypeId { get; set; }

        [ForeignKey("NotificationTypeId")]
        public NotificationType? NotificationType { get; set; }

        public int? EntityId { get; set; }  // Reference to the related entity

        public string Message { get; set; } = "";

        [Required]
        public bool IsRead { get; set; } = false;

        [Required]
        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}
