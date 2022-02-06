using Dutch.Services;
using Dutch.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Dutch.Controllers
{
    public class AppController : Controller
    {
        private readonly IMailService _mailService;

        public AppController(IMailService mailService)
        {
            _mailService = mailService;
        }
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
            ViewBag.Title = "Contact Us";
            if (ModelState.IsValid)
            {
                _mailService.SendMessage("nazmia@capella.io", model.Subject, $"From: {model.Name} - {model.Email}, Message: {model.Message}");
                ViewBag.UserMessage = "Mail Sent";
                ModelState.Clear();
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
