using Microsoft.AspNetCore.Mvc;
using RecruitingWeb.Models;
using System.Diagnostics;

namespace RecruitingWeb.Controllers
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
            return View(); //by default return the action name Index(), can specify

        }

        public IActionResult Privacy()
        {
            return View();
        }


        public IActionResult Jobs()
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