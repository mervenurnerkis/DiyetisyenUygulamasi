using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimMimarisiODevi
{
    public class Hastalik : IHastalik
    {
        public string diyetYaz()
        {
            return "Yeni hastalığa uygun diyet yazıldı";
        }

        public string HastalikAdi()
        {
            return "Yeni hastalık oluşturuldu";
        }
    }
}
