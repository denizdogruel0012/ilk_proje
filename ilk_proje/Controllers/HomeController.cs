using Microsoft.AspNetCore.Mvc;

namespace ilk_proje.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Index2()
        {
            return View();
        }
        public int Index3() {

            return 24;
        }public string Index4()
        {
            return "merhaba bugün hava çok soğuk";
        }
    }
}
