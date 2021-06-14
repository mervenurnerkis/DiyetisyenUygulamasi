using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazilimMimarisiODevi
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GirişEkranı());

            /*IHastalik obez = new Obez();
            IHastalik seker = new Seker();
            IHastalik colyak = new Colyak();

            List<string> hastalikTurleri = new List<string>() { "Obez", "Şeker", "Çölyak" };


            IDiyetTurleri denizUrunleri = new DenizUrunleri();
            IDiyetTurleri glutenFree = new GlutenFree();
            IDiyetTurleri akdeniz = new Akdeniz();
            //IDiyetTurleri yesilliklerDunyasi = new YesilliklerDunyasi();

            List<string> diyetTurleri = new List<string>() { "Deniz Ürünleri", "GlutenFree", "Akdeniz", "Yeşillikler Dünyası" };*/







            // Hasta hasta1 = new Hasta {Ad="Batuhan", Soyad="Dinç", Hastaligi="Mervesizlik", TC="00000", Email="asdsdadsa" };



        }
    }
}
