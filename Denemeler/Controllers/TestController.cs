using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Denemeler.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Listele()
        {
            return View(Models.OgrenciVeri.Ogrenciler);
        }

        public IActionResult Yeni()
        {
            return View();
        }
        

        [HttpPost]
        public IActionResult Yeni(Models.Ogrenci ogrenci)
        {
            Models.OgrenciVeri.Ogrenciler.Add(ogrenci);
            return RedirectToAction("Listele");
        }

        public IActionResult GetDetay(int id)
        {
            var x = Models.OgrenciVeri.Ogrenciler.FirstOrDefault(x => x.Id == id);
            return View(x);
        }

    }
}
