using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBg.Models
{
    public class ProfileViewModel
    {
        public UserAdminModel admin { get; set; }

        public IEnumerable<FollowerModel> followers {get; set; }
    }
}
