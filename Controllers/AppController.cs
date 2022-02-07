using Dutch.Data;
using Dutch.Services;
using Dutch.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace Dutch.Controllers
{
    public class AppController : Controller
    {
        private readonly IMailService _mailService;
        private readonly IDutchRepository _repository;

        public AppController(IMailService mailService, IDutchRepository repository)
        {
            _mailService = mailService;
            _repository = repository;
           
        }
        public IActionResult Index()
        {
           // var results = _repository.Products.ToList();
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

        public IActionResult Shop()
        {
            var results =  _repository.GetAllProducts();
                /*_context.Products
                .OrderBy(p => p.Category)
                .ToList();*/
            return View(results);
        }
    }
}
