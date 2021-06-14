using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimMimarisiODevi
{
    public class DiyetFabrikasi
    {
        public IDiyetTurleri diyetYaz()
        {

            return new DiyetTurleri();
        }
    }
}
