using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimMimarisiODevi
{
    public interface IHasta 
    {
        Hasta hastaEkle(string ad, string soyad, string tc, string email, string hastalik, string diyet);
    }
}
