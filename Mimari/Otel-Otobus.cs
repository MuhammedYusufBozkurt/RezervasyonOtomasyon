using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mimari
{
    public class Otel_Otobus:ISoyutFabrika
    {
        public IKonaklama KonaklamaOlustur()
        {
            return new Otel();
        }
        public IUlasim UlasimOlustur()
        {
            return new Otobus();
        }
    }
}
