using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimMimarisiODevi
{
    public class Hasta:IHasta
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TC { get; set; }
        public string Email { get; set; }
        public string Hastalik { get; set; }
        public string DiyetTuru { get; set; }

        public Hasta hastaEkle(string ad, string soyad, string tc, string email, string hastalik, string diyet)
        {
            Hasta hasta1 = new Hasta();
            hasta1.Ad = ad;
            hasta1.Soyad = soyad;
            hasta1.TC = tc;
            hasta1.Email = email;
            hasta1.Hastalik = hastalik;
       

            if (diyet == "Gluten Free")
            {
                GlutenFree glutenfree1 = new GlutenFree();
                hasta1.DiyetTuru = glutenfree1.diyetYaz();
            }
            else if(diyet == "Deniz Ürünleri")
            {
                DenizUrunleri denizUrunleri1 = new DenizUrunleri();
                hasta1.DiyetTuru = denizUrunleri1.diyetYaz();
            }
            else if(diyet == "Akdeniz")
            {
                Akdeniz akdeniz1 = new Akdeniz();
                hasta1.DiyetTuru = akdeniz1.diyetYaz();
            }
            else if (diyet == "Yeşillikler Dünyası")
            {
                YesilliklerDunyasi yesilliklerDunyasi1 = new YesilliklerDunyasi();
                hasta1.DiyetTuru = yesilliklerDunyasi1.diyetYaz();
            }


            return hasta1;
        }
    }
}
