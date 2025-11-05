using ilk_proje.Models;
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
        }public IActionResult Index5()
        {
            var ktp = new List<Kitap>()
            {
                new Kitap(){Id=1,KitapAd="80 Günde devri alem",Yazar="Jules Verne"},
                new Kitap(){Id=2,KitapAd="Bilinmeyen Bir kadının mektubu",Yazar="zweig" },
                new Kitap(){Id=3,KitapAd="Bir Noel Hikayesi",Yazar="Charles Dickens" }

            };

            return View(ktp);
        }
    }
}
