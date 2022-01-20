using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBg.Controllers
{
    public class ToolsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ReadingSpeed()
        {
            return View("Reading_Speed");
        }

        public IActionResult CitationMachine()
        {
            return View("Citation_Machine");
        }
    }
}
