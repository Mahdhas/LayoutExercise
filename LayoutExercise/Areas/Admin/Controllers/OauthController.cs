using Microsoft.AspNetCore.Mvc;

namespace LayoutExercise.Areas.Admin.Controllers
{
    [Area("admin")]
    public class OauthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
    }
}
