using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScienceBasedMealsApi.Models
{
    public enum ApprovalStatus
    {
        Pending,
        Approved,
        Rejected
    }

    public class MealApproval
    {
        [Key]
        public int Id { get; set; }  // approval_id

        [Required]
        public int MealVersionId { get; set; }

        [ForeignKey("MealVersionId")]
        public required MealVersion MealVersion { get; set; }

        [Required]
        public int ReviewerUserId { get; set; }

        [ForeignKey("ReviewerUserId")]
        public required User ReviewerUser { get; set; }

        [Required]
        public ApprovalStatus ApprovalStatus { get; set; }

        public string Critique { get; set; } = "";

        [Required]
        public DateTime ApprovalDate { get; set; }
    }
}
