using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MimeKit;
using MimeKit.Text;
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

            Console.WriteLine("HEYYYY!!!");

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

            // --------------------- send the email ----------------- //
            string html = "<div style=\" background: #242424; width: 100%; height: 100%; margin: 0; padding: 2rem  0;\"> <img style=\"display: block; margin: auto;\" src= \"https://res.cloudinary.com/dq6prlmvh/image/upload/v1643996317/danielrangel.me/Email/logo_hbbtbu.png\" alt=\"logo of danel rangel dot com\"/> <p style = \"width: 90%; margin: 2.5rem auto; text-align: center; font: 600 2rem sans-serif; line-height: 1.3em; color: #CF0EFF;\">Thank you for following my site. No worries, I won't bombard your email with meaningless stuff. Just whenever new goodies are out :)</p> <p style = \"width: 90%; margin: 3rem auto; text-align: center; color: #FF6B00; font: 600 1.5rem sans-serif; \"> BLESSINGS, IN THE NAME OF JESUS CHRIST</p> </div>";
            // create email message
            var email = new MimeMessage();
            email.From.Add(new MailboxAddress("Danielrangel.me", "xharccoal@gmail.com"));
            email.To.Add(MailboxAddress.Parse(follower.Email));
            email.Subject = "Thank you for following danielrangel.me!";
            email.Body = new TextPart(TextFormat.Html) { Text = html };

            // send email
            SmtpClient smtp = new SmtpClient();

            try
            {
                smtp.Connect("smtp.gmail.com", 465, true);
                smtp.Authenticate("xharccoal@gmail.com", "*EMxh4rc04lY0121*");
                //smtp.Authenticate("drangelll@outlook.com", "Yodarango2*");
                smtp.Send(email);

                Console.WriteLine("Email was sent!");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                smtp.Disconnect(true);
                smtp.Dispose();
            }





            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
