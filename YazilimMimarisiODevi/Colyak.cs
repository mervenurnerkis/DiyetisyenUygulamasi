using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimMimarisiODevi
{
    public class Colyak : IHastalik
    {
        public string diyetYaz()
        {
            return "Gluten Free";
        }
        public string HastalikAdi()
        {
             return "Colyak";
        }
        
    }
}
