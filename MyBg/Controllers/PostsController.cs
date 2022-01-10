using Microsoft.AspNetCore.Mvc;
using MyBg.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBg.Controllers
{
    public class PostsController : Controller
    {
        public IActionResult Index()
        {
            PostsContext context = HttpContext.RequestServices.GetService(typeof(MyBg.Data.PostsContext)) as PostsContext;

            ViewData["Blogs"] = context.GetBlogs();
            ViewData["Favorites"] = context.GetFavorites();

            return View("Index");
        }

        public IActionResult Posts(string tag)
        {


            return View();
        }

    }
}
