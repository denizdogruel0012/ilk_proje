using Microsoft.AspNetCore.Mvc;

namespace ilk_proje.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
