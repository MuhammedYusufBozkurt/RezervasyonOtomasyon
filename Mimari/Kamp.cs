using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mimari
{
    public class Kamp: IKonaklama
    {
        public string KampAdi { get; set; }
        public int GunlukFiyat { get; set; }
        public DateTime GirisTar { get; set; }
        public DateTime CikisTar { get; set; }
        public string KonaklamaBilgisi() 
        {
            return "Kamp Olustu";
        }
    }
}
