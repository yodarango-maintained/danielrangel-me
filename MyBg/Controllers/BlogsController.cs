using Microsoft.AspNetCore.Mvc;
using MyBg.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBg.Controllers
{
    public class BlogsController : Controller
    {
        public IActionResult Index()
        {
            PostsContext context = HttpContext.RequestServices.GetService(typeof(MyBg.Data.PostsContext)) as PostsContext;
            return View("Index", context.GetBlogs());
        }

        public IActionResult Post(int id)
        {
            PostsContext context = HttpContext.RequestServices.GetService(typeof(MyBg.Data.PostsContext)) as PostsContext;
            return View("Post", context.GetOneBlog(id));
        }
    }
}
