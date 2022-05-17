using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mimari
{
    public class Kamp_Ucak:ISoyutFabrika
    {
        public IKonaklama KonaklamaOlustur()
        {
            return new Kamp();
        }
        public IUlasim UlasimOlustur()
        {
            return new Ucak();
        }
    }
}
