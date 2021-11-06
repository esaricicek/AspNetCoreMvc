using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Denemeler.Models
{
    public class OgrenciVeri
    {
        public static List<Ogrenci> Ogrenciler = new List<Ogrenci>() 
        { 
            new Ogrenci()
                        {
                            Id = 1, 
                            Ad = "Emrah", 
                            Soyad = "Sari",
                            BolumAd = "Bilgisayar", 
                            GirisYil= 2019, 
                            TCKimlikNo="12345656789"
                        },
            new Ogrenci()
                        {
                            Id = 2,
                            Ad = "Emre",
                            Soyad = "Sar",
                            BolumAd = "Bilgisayar",
                            GirisYil= 2019,
                            TCKimlikNo="22345656789"
                        },
            new Ogrenci()
                        {
                            Id = 3,
                            Ad = "Emine",
                            Soyad = "Sar",
                            BolumAd = "Bilgisayar",
                            GirisYil= 2019,
                            TCKimlikNo="72345656789"
                        }
        };
    }
}
