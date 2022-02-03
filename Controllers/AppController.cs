using Microsoft.AspNetCore.Mvc;

namespace Dutch.wwwroot
{
    public class AppController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
