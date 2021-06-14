using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazilimMimarisiODevi
{
    public partial class GirişEkranı : Form
    {
        public GirişEkranı()
        {
            InitializeComponent();
        }

            private void btnGiris_Click(object sender, EventArgs e)
            {
                if (txtKullaniciAdi.Text == "admin" && txtSifre.Text == "admin")
                {

                    Admin fr = new Admin();
                    fr.Show();
                    this.Hide();
                }
                else if (txtKullaniciAdi.Text == "diyetisyen" && txtSifre.Text == "diyetisyen")
                {

                    DiyetisyenAnaEkran fr1 = new DiyetisyenAnaEkran();
                    fr1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Giriş Başarısız");
                }
            }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState==CheckState.Checked)
            {
                txtSifre.UseSystemPasswordChar = true;
            }
            else if(checkBox1.CheckState==CheckState.Unchecked)
            {
                txtSifre.UseSystemPasswordChar = false;
            }
        }

        private void GirişEkranı_Load(object sender, EventArgs e)
        {

        }
    }
}
