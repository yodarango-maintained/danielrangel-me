using Microsoft.AspNetCore.Mvc;
using MyBg.Data;
using MyBg.Models;
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

            ViewData["FollowerCount"] = usersContext.GetFollowerCount();

            return View("Index", usersContext.Getindexdata());
        }

        public IActionResult Blogs()
        {
            PostsContext postsContext = HttpContext.RequestServices.GetService(typeof(MyBg.Data.PostsContext)) as PostsContext;

            return View("Blogs", postsContext.GetBlogs());
        }

        public IActionResult Favorites()
        {
            PostsContext postsContext = HttpContext.RequestServices.GetService(typeof(MyBg.Data.PostsContext)) as PostsContext;

            return View("Favorites", postsContext.GetFavorites());
        }



        public IActionResult Followers()
        {
            UsersContext userContext = HttpContext.RequestServices.GetService(typeof(MyBg.Data.UsersContext)) as UsersContext;

            return View("Followers", userContext.GetFollowers());
        }
        // -------------------------------------------- Post Routes ------------------------------------- //

        [HttpPost]
        public IActionResult EditUserAdmin(UserAdminModel admin)
        {
            UsersContext usersContext = HttpContext.RequestServices.GetService(typeof(MyBg.Data.UsersContext)) as UsersContext;

            usersContext.EditUserAdmin(admin);

            ViewData["FollowerCount"] = usersContext.GetFollowerCount();

            return View("Index", usersContext.Getindexdata());
        }
    }
}
