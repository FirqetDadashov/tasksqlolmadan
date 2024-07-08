using Microsoft.AspNetCore.Mvc;

namespace WebApplicationtapsiriq.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
