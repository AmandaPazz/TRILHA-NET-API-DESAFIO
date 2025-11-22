using Microsoft.AspNetCore.Mvc;

namespace TrilhaApiDesafio.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

