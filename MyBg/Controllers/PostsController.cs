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
            PostsContext context = HttpContext.RequestServices.GetService(typeof(PostsContext)) as PostsContext;
            List<PostsViewModel> posts = context.GetPostsByTag(tag);

            if (!String.IsNullOrEmpty(tag)) {
                ViewData["Tag"] = $"{tag} Category";
            } else {
                ViewData["Tag"] = "All posts";
            }
            return View("Index", posts);
        }

        //------------------------- Handle Likes ---------------------- //
        public class LikeObj
        {
            public int id { get; set; }
            public string post { get; set; }
            public int likes { get; set; }
        }

        public class ShareObj
        {
            public int id { get; set; }
            public string post { get; set; }
            public int shares { get; set; }
        }


        [HttpPost]
        //[ValidateAntiForgeryToken]
        public void LikePost([FromBody] LikeObj requestData)
        {

            PostsContext context = HttpContext.RequestServices.GetService(typeof(PostsContext)) as PostsContext;

            context.LikePost(requestData.id, requestData.post, requestData.likes);

        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public void sharePost([FromBody] ShareObj requestData)
        {

            PostsContext context = HttpContext.RequestServices.GetService(typeof(PostsContext)) as PostsContext;

            context.SharePost(requestData.id, requestData.post, requestData.shares);

        }


    }
}
