using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Denemeler.Controllers
{
    public class OgrenciController : Controller
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
        public IActionResult Yeni(Models.Ogrenci yeniOgrenci)
        {
            Models.OgrenciVeri.Ogrenciler.Add(yeniOgrenci);
            return RedirectToAction("Listele");            
        }

        public IActionResult Guncelle(int id)
        {
            //  Linq
            //select top 1 * from Ogrenciler where Id = ogrenciId
            var r = Models.OgrenciVeri.Ogrenciler.FirstOrDefault(x => x.Id == id);
            return View(r);
        }

        [HttpPost]
        public IActionResult Guncelle(Models.Ogrenci ogrenci)
        {
            var c = Models.OgrenciVeri.Ogrenciler.FirstOrDefault(x => x.Id == ogrenci.Id);

            var r = Models.OgrenciVeri.Ogrenciler.FirstOrDefault(x => x.Id == ogrenci.Id);
            r.Ad = ogrenci.Ad;
            r.Soyad = ogrenci.Soyad;
            r.BolumAd = ogrenci.BolumAd;
            r.TCKimlikNo = ogrenci.TCKimlikNo;
            r.GirisYil = ogrenci.GirisYil;
            
            Models.OgrenciVeri.Ogrenciler.Remove(c);

            Models.OgrenciVeri.Ogrenciler.Add(r);

            return RedirectToAction("Listele");
        }


        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
