using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScienceBasedMealsApi.Models
{
    public class UserConnection
    {
        [ForeignKey("FollowerUser")]
        public int FollowerUserId { get; set; }

        public User? FollowerUser { get; set; }

        [ForeignKey("FollowedUser")]
        public int FollowedUserId { get; set; }

        public User? FollowedUser { get; set; }

        public DateTime ConnectionDate { get; set; }
    }
}
