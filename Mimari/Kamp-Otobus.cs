using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mimari
{
   
    public class Kamp_Otobus:ISoyutFabrika
    {
        public string KampAdi { get; set; }
        public int GunlukKampFiyat { get; set; }
        public int OtobusBiletFiyat { get; set; }
        public string OtobusAdi { get; set; }
        public decimal KisiSay { get; set; }
        public DateTime GirisTar { get; set; }
        public DateTime CikisTar { get; set; }
        public bool durum { get; set; }
        public decimal Tutar()
        {
            TimeSpan ts =  CikisTar - GirisTar;
            Math.Abs(int.Parse(ts.ToString()));
            decimal gunsay = ts.Days;
            if (gunsay == 0)
            {
                gunsay = 1;
            }
            if (durum==false)
            {

            }
           


            return tutar;
        }
        public IKonaklama KonaklamaOlustur()
        {
            return new Kamp();
        }
        public IUlasim UlasimOlustur()
        {
            return new Otobus();
        }
    }
}
