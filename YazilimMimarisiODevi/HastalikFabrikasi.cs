using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimMimarisiODevi
{
    public class HastalikFabrikasi
    {
        public IHastalik HastalikNesnesiOlustur()
        {

            return new Hastalik();
        }
    }
}
