using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mimari
{
    public class Otel_Ucak:ISoyutFabrika
    {
        public string OtelAdi { get; set; }
        public int GunlukOtelFiyat { get ; set; }
        public int UcakBiletFiyat { get; set; }
        public string UcakAdi { get; set; }
        public decimal KisiSay { get; set; }
        public DateTime GirisTar { get; set; }
        public DateTime CikisTar { get; set; }
        public bool durum { get; set; }

        public decimal Tutar() 
        {
            decimal tutar = 0;
            TimeSpan ts = CikisTar - GirisTar;
            decimal gunsay=ts.Days;
            if (gunsay==0)
            {
                gunsay = 1;
            }
            if (durum==false)
            {
                 tutar = Convert.ToDecimal((GunlukOtelFiyat * gunsay + UcakBiletFiyat*2) * KisiSay);
            }
            else
            {
                 tutar = Convert.ToDecimal((GunlukOtelFiyat*gunsay+UcakBiletFiyat)*KisiSay);
            }
            


            return tutar;
        }
        public IKonaklama KonaklamaOlustur() 
        {
            return new Otel();
        }
        public IUlasim UlasimOlustur()
        {
            return new Ucak();
        }


       
    }
}
