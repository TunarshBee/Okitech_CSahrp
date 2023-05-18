using Microsoft.AspNetCore.Mvc;

namespace OkitechWebApp.Controllers
{
    public class Welcome : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
