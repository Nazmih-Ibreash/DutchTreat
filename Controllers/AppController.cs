using Dutch.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Dutch.Controllers
{
    public class AppController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("contact")]
        public IActionResult Contact()
        {
            ViewBag.Title = "Contact Us";
            return View();
        }
        [HttpPost("contact")]
        public IActionResult Contact(ContentViewModel model)
        {
            if (ModelState.IsValid)
            {
                //send email
                ViewBag.Title = "Contact Us";
            }
            else
            {
                //show the errors
            }
            return View();

        }

        [HttpGet("about")]
        public IActionResult About()
        {
            ViewBag.Title = "Abou Us";
            return View();
        }
    }
}
