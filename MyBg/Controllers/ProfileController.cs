using Microsoft.AspNetCore.Mvc;
using MyBg.Data;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBg.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            UsersContext usersContext = HttpContext.RequestServices.GetService(typeof(MyBg.Data.UsersContext)) as UsersContext;
            PostsContext postsContext = HttpContext.RequestServices.GetService(typeof(MyBg.Data.PostsContext)) as PostsContext;

            ViewData["Followers"] = usersContext.GetFollowers();
            ViewData["Blogs"] = postsContext.GetBlogs();
            ViewData["Favorites"] = postsContext.GetFavorites();
            ViewData["UserAdmin"] = usersContext.Getindexdata();

            return View("Index");
        }
    }
}
