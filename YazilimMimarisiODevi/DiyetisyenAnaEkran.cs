using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Data.SqlClient;
using System.Data.Sql;

namespace YazilimMimarisiODevi
{
    public partial class DiyetisyenAnaEkran : Form
    {
        public DiyetisyenAnaEkran()
        {
            InitializeComponent();
        }
      

        private void DiyetisyenAnaEkran_Load(object sender, EventArgs e)
        {
            this.tbl_AkdenizTableAdapter1.Fill(this.diyetListesiDataSet4.Tbl_Akdeniz);
            this.tbl_BalikTableAdapter.Fill(this.diyetListesiDataSet3.Tbl_Balik);
            this.tbl_YesilliklerTableAdapter.Fill(this.diyetListesiDataSet2.Tbl_Yesillikler);
            this.diyetTableAdapter.Fill(this.diyetListesiDataSet.Diyet);         
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem.ToString().Contains("Gluten Free"))
             {
                dataGridView2.Visible = false;
                dataGridView3.Visible = false;
                dataGridView4.Visible = false;
                dataGridView1.Visible = true;

            }
            else if(listBox1.SelectedItem.ToString().Contains("Akdeniz"))
            {
               
                dataGridView1.Visible = false;
                dataGridView3.Visible = false;
                dataGridView4.Visible = false;
                dataGridView2.Visible = true;

            }
            else if (listBox1.SelectedItem.ToString().Contains("Yeşillikler Dünyası"))
            {
             
                dataGridView1.Visible = false;
                dataGridView2.Visible = false;
                dataGridView4.Visible = false;
                dataGridView3.Visible = true;
            }
            else if (listBox1.SelectedItem.ToString().Contains("Deniz Ürünleri"))
            {
                dataGridView1.Visible = false;
                dataGridView2.Visible = false;
                dataGridView3.Visible = false; 
                dataGridView4.Visible = true;
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            cmbBxHastalik.Items.Add(hastalikEkleBox.Text);

            MessageBox.Show("Hastalik Eklendi");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmbBxDiyetTuru.Items.Add(diyetEkleBox.Text);
            MessageBox.Show("Diyet Türü Eklendi");
        }

       
        string hastatc;
        private void HastaEkleButonu_Click(object sender, EventArgs e)
        {
            string ad = txtBxAd.Text;
            string soyad = txtBxSoyad.Text;
            string tc = mskTC.Text;
            string hastalik = cmbBxHastalik.Text;
            string email = txtBxEmail.Text;
            string diyet = cmbBxDiyetTuru.Text;

            if (string.Compare(mskTC.Text, hastatc) == 0)
            {
                MessageBox.Show("Bu Hastaya Daha Önce Diyet Atanmıştır.");
            }
            else
            {
                Hasta hasta1 = new Hasta();
                HastaFabrikasi hastaFab = new HastaFabrikasi();
                IHasta hasta = hastaFab.HastaNesnesiOlustur();
                hasta1 = hasta.hastaEkle(ad, soyad, tc, email, hastalik, diyet);
                listBox1.Items.Add(hasta1.Ad + "\t" + hasta1.Soyad + "\t" + hasta1.TC + "\t" + hasta1.Email + "\t" + hasta1.Hastalik + "\t" + hasta1.DiyetTuru);
                hastatc = mskTC.Text;
            }
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            if (string.Compare(cmbBxRapor.Text, "Diyet Listesi+Hasta") == 0)
            {
                StreamWriter deneme = new StreamWriter(File.Create("rapor.html"));
                deneme.WriteLine("<h1>HASTA DİYET LİSTESİ<h1>");

                List<string> gunler = new List<string>() { "PAZARTESİ", "SALI", "ÇARŞAMBA", "PERŞEMBE", "CUMA", "CUMARTESİ", "PAZAR" };
                int k = 0;
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    deneme.WriteLine("<br>" + gunler[k]);
                    for (int j = 0; j < dataGridView1.Rows.Count - 1; j++)
                    {
                        deneme.WriteLine("<p>" + "\t" + dataGridView1.Rows[j].Cells[i].Value.ToString() + "\t" + "<p>");

                    }
                    k++;

                }

                deneme.WriteLine("<h1>HASTA BİLGİLERİ<h1>");
                deneme.WriteLine("<h2>Hasta Adı |&nbsp  Tc Kimlik | E Mail |&nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp Hastalık |&nbsp Diyet Türü |");
                deneme.WriteLine("<p>" + listBox1.SelectedItem.ToString() + "<p>");
                deneme.Close();
            }
            else
            {
                StreamWriter deneme = new StreamWriter(File.Create("rapor.html"));
                deneme.WriteLine("<h1>HASTA BİLGİLERİ<h1>");
                deneme.WriteLine("<h2>Hasta Adı |&nbsp  Tc Kimlik | E Mail |&nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp Hastalık |&nbsp Diyet Türü |");
                deneme.WriteLine("<p>" + listBox1.SelectedItem.ToString() + "<p>");
                deneme.WriteLine("<h1>HASTA DİYET LİSTESİ<h1>");

                List<string> gunler = new List<string>() { "PAZARTESİ", "SALI", "ÇARŞAMBA", "PERŞEMBE", "CUMA", "CUMARTESİ", "PAZAR" };
                int k = 0;
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    deneme.WriteLine("<br>" + gunler[k]);
                    for (int j = 0; j < dataGridView1.Rows.Count - 1; j++)
                    {
                        deneme.WriteLine("<p>" + "\t" + dataGridView1.Rows[j].Cells[i].Value.ToString() + "\t" + "<p>");

                    }
                    k++;

                }
                deneme.Close();
            }
            Rapor rapor1 = new Rapor();
            string mesaj = rapor1.RaporAl();
            MessageBox.Show(mesaj);
        }
    
    }
}

