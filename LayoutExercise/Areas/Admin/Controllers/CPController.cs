using LayoutExercise.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LayoutExercise.Controllers
{
    [Area("admin")]

    [Route("{controller}")]
    public class CPController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public CPController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
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