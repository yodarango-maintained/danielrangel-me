using Microsoft.AspNetCore.Mvc;
using MyBg.Data;
using MyBg.Models;
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

        [Route("Blogs/{id:int}")]
        public IActionResult Post(int id)
        {
            PostsContext context = HttpContext.RequestServices.GetService(typeof(MyBg.Data.PostsContext)) as PostsContext;
            return View("Post", context.GetOneBlog(id));
        }

        public IActionResult New()
        {
            return View();
        }

        public IActionResult Edit(int id)
        {
            PostsContext context = HttpContext.RequestServices.GetService(typeof(MyBg.Data.PostsContext)) as PostsContext;

            return View("Edit", context.GetOneBlog(id));
        }

        // ------------------------------------- post routes --------------------------------------------- //

        [HttpPost]
        [ValidateAntiForgeryToken]
        public void Newblog(BlogModel blog)
        {
            PostsContext context = HttpContext.RequestServices.GetService(typeof(MyBg.Data.PostsContext)) as PostsContext;
            context.NewBlog(blog);
        }

        public void Editblog(BlogModel blog)
        {
            PostsContext context = HttpContext.RequestServices.GetService(typeof(MyBg.Data.PostsContext)) as PostsContext;
            context.EditBlog(blog);
        }

        // ---------------------------------------------- Delete Routes ----------------------------------------
        public IActionResult DeleteBlog(int id)
        {
            PostsContext context = HttpContext.RequestServices.GetService(typeof(MyBg.Data.PostsContext)) as PostsContext;
            context.DeleteBlog(id);

            return View("Index", context.GetBlogs());
        
        }
    }
}
