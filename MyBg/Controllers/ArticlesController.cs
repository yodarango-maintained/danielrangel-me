using Microsoft.AspNetCore.Mvc;
using MyBg.Data;

namespace MyBg.Controllers
{
    public class ArticlesController : Controller
    {
        public IActionResult Index()
        {
            PostsContext context = HttpContext.RequestServices.GetService(typeof(MyBg.Data.PostsContext)) as PostsContext;
            ViewData["Tags"] = context.GetCategoryTags();

            return View("Index", context.GetBlogs());
        }

        [Route("Articles/{id:int}")]
        public IActionResult Post(int id)
        {
            PostsContext context = HttpContext.RequestServices.GetService(typeof(MyBg.Data.PostsContext)) as PostsContext;

            ViewData["Post"] = id.ToString();
            return View("Post", context.GetOneBlog(id));
        }

        //public IActionResult New()
        //{
        //    return View();
        //}

        //public IActionResult Edit(int id)
        //{
        //    PostsContext context = HttpContext.RequestServices.GetService(typeof(MyBg.Data.PostsContext)) as PostsContext;

        //    return View("Edit", context.GetOneBlog(id));
        //}

        // ------------------------------------- post routes --------------------------------------------- //

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public void Newblog(ArticleModel blog)
        //{
        //    PostsContext context = HttpContext.RequestServices.GetService(typeof(MyBg.Data.PostsContext)) as PostsContext;
        //    context.NewBlog(blog);
        //}

        //public void Editblog(ArticleModel blog)
        //{
        //    PostsContext context = HttpContext.RequestServices.GetService(typeof(MyBg.Data.PostsContext)) as PostsContext;
        //    context.EditBlog(blog);
        //}

        //// ---------------------------------------------- Delete Routes ----------------------------------------
        //public IActionResult DeleteBlog(int id)
        //{
        //    PostsContext context = HttpContext.RequestServices.GetService(typeof(MyBg.Data.PostsContext)) as PostsContext;
        //    context.DeleteBlog(id);

        //    return View("Index", context.GetBlogs());

        //}
    }
}
