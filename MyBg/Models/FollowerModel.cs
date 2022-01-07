using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyBg.Models
{
    public class FollowerModel
    {
        public int ID { get; set; }

        [Required]
        public string Follower_Name { get; set; }

        public DateTime Date_Subscribed { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public bool Not_A_Bot { get; set; }

        [Required]
        public string Avatar { get; set; }

    }
}
