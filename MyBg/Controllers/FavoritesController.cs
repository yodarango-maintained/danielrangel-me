using Microsoft.AspNetCore.Mvc;
using MyBg.Data;
using MyBg.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBg.Controllers
{
    public class FavoritesController : Controller
    {
        public IActionResult Index()
        {
            PostsContext context = HttpContext.RequestServices.GetService(typeof(MyBg.Data.PostsContext)) as PostsContext;
            return View("Index", context.GetFavorites());
        }

        public IActionResult Post(int id)
        {
            PostsContext context = HttpContext.RequestServices.GetService(typeof(MyBg.Data.PostsContext)) as PostsContext;
            return View("Post", context.GetOneFavorite(id));
        }

        public IActionResult New()
        {
            return View("New");
        }

        public IActionResult Edit(int id)
        {
            PostsContext context = HttpContext.RequestServices.GetService(typeof(MyBg.Data.PostsContext)) as PostsContext;

            return View("Edit", context.GetOneFavorite(id));
        }

        //----------------------------------  post routes ----------------------------
        [HttpPost]
        [ValidateAntiForgeryToken]
        public void NewFavorite(FavoriteModel favorite)
        {
            PostsContext context = HttpContext.RequestServices.GetService(typeof(MyBg.Data.PostsContext)) as PostsContext;
            context.NewFavorite(favorite); 
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public string EditFavorite(FavoriteModel favorite)
        {
            PostsContext context = HttpContext.RequestServices.GetService(typeof(MyBg.Data.PostsContext)) as PostsContext;
            return context.EditFavorite(favorite);
        }

        //----------------------------------  delete routes ----------------------------

        public IActionResult DeleteFavorite(int id)
        {
            PostsContext context = HttpContext.RequestServices.GetService(typeof(MyBg.Data.PostsContext)) as PostsContext;
            context.DeleteFavorite(id);

            return View("Index", context.GetFavorites());
        }
    }
}
