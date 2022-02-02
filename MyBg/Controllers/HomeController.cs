using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyBg.Data;
using MyBg.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MyBg.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["SubsMessage"] = false;

            UsersContext usersContext = HttpContext.RequestServices.GetService(typeof(MyBg.Data.UsersContext)) as UsersContext;
            PostsContext postContext = HttpContext.RequestServices.GetService(typeof(MyBg.Data.PostsContext)) as PostsContext;

            ViewData["User"] = usersContext.Getindexdata();
            ViewData["FollowerCount"] = usersContext.GetFollowerCount();
            ViewData["Posts"] = postContext.GetAllPosts();

            return View("Index");
        }


        public IActionResult Subscribe(FollowerModel follower)
        {

            UsersContext context = HttpContext.RequestServices.GetService(typeof(MyBg.Data.UsersContext)) as UsersContext;
            context.AddFollower(follower);

            ViewData["SubsMessage"] = true;

            UsersContext usersContext = HttpContext.RequestServices.GetService(typeof(MyBg.Data.UsersContext)) as UsersContext;
            PostsContext postContext = HttpContext.RequestServices.GetService(typeof(MyBg.Data.PostsContext)) as PostsContext;

            ViewData["User"] = usersContext.Getindexdata();
            ViewData["FollowerCount"] = usersContext.GetFollowerCount();
            ViewData["Posts"] = postContext.GetAllPosts();

            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
