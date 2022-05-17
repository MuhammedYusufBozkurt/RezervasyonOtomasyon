using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mimari
{
    public class Ucak : IUlasim
    {
        public string UcakFirma { get; set; }
        public int Tutar { get; set; }
        public DateTime GidisTar { get; set; }
        public DateTime DonusTar { get; set; }
        
    }
}
