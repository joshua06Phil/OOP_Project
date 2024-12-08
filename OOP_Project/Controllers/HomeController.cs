using Microsoft.AspNetCore.Mvc;
using OOP_Project.Models;
using System.Diagnostics;

namespace OOP_Project.Controllers
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
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

      
       
        public IActionResult Airplane()
        {
            return View();
        }
        public IActionResult Source()
        {
            return View();
        }


        public IActionResult Cessna()
            {
                return View();
            }

        public IActionResult dashboard()
        {
            return View();
        }

        public IActionResult Airbus()
        {
            return View();
        }
        public IActionResult boeing()
        {
            return View();
        }
        public IActionResult loginform()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
