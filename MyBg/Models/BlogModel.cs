using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyBg.Models
{
    public class BlogModel
    {
        public int ID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Tumbnails { get; set; }
        [Required]
        public string Categories { get; set; }

        public DateTime DatePosted { get; set; }

        [Required]
        public string HTML { get; set; }

        public string PostType { get; set; }
    }
}
