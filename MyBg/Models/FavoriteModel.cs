using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBg.Models
{
    public class FavoriteModel
    {
        public int ID { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Tumbnails { get; set; }

        public string Categories { get; set; }

        public DateTime DatePosted { get; set; }
        
        public string? Link { get; set; }

        public string HTML { get; set; }
    }
}
