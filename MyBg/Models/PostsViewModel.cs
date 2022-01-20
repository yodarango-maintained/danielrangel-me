using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBg.Models
{
    public class PostsViewModel
    {
        public int ID { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Tumbnails { get; set; }

        public DateTime DatePosted { get; set; }

        public string PostType { get; set; }

        public string Categories { get; set; }
    }
}
