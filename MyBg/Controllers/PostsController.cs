using Microsoft.AspNetCore.Mvc;
using MyBg.Data;
using MyBg.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBg.Controllers
{
    public class PostsController : Controller
    {

        public IActionResult Index(string tag)
        {
            PostsContext context = HttpContext.RequestServices.GetService(typeof(MyBg.Data.PostsContext)) as PostsContext;
            List<PostsViewModel> posts = context.GetPostsByTag(tag);

            if (!String.IsNullOrEmpty(tag)) {
                ViewData["Tag"] = $"{tag} Category";
            } else {
                ViewData["Tag"] = "All posts";
            }
            return View("Index", posts);
        }

    }
}
