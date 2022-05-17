using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mimari
{
    public class Otobus:IUlasim
    {
        public string OtobusFirmaAdi { get; set; }
        public int Tutar { get; set; }
        public DateTime GidisTar { get; set; }
        public DateTime DonusTar { get; set; }
        
    }
}
