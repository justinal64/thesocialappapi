using Microsoft.AspNetCore.Mvc;

namespace TheSocialAppApi.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}