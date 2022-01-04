using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyBg.Models
{
    public class UserAdminModel
    {
        public int ID { get; set; }

        public string About_Me { get; set; }

        [Display(Name = "You Version")]
        public string YouVersion_Url { get; set; }

        [Display(Name = "GitHub")]
        public string Github_Url { get; set; }


        [Display(Name = "Instagram")]
        public string Instagram_Url { get; set; }

        [Display(Name = "Redit")]
        public string Reddit_Url { get; set; }

        [Display(Name = "Goodreads")]
        public string Goodreads_url { get; set; }

        [Display(Name = "YouTube")]
        public string Youtube_url { get; set; }

        [Display(Name = "Twitter")]
        public string Twitter_url { get; set; }

        [Display(Name = "LinkedIn")]
        public string LinkedIn_url { get; set; }

        [Display(Name = "Strava")]
        public string Strava_url { get; set; }

        public string Categories { get; set; }
    }
}
