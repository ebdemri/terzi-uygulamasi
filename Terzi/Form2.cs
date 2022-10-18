using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Terzi
{
    public partial class Form2 : Form
    {
        public static decimal ToplamSatisTutari = 0;
        public static decimal GeciciTutar = 0;
        public Form2()
        {
            InitializeComponent();
        }
        public static UrunKatalogu UrunKatalogu = new UrunKatalogu();
        public static Dikim Dikim = new Dikim();
        public static Satis Satis = new Satis();
        public static İscilik İscilikorani = new İscilik();
        public static İscilik İscilik1 = new İscilik();



        private void Form2_Load(object sender, EventArgs e)
        {
            foreach (Urun u in UrunKatalogu.Dukkan.UrunListesi)
            {
                lbKiyafetT.Items.Add(u);
            }
            if (lbKiyafetT.SelectedItem == null)
            {
                btnHesapla.Enabled = false;
            }
            else
            {
                btnHesapla.Enabled = true;
            }
        }

        

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            Urun u = (Urun)lbKiyafetT.SelectedItem;
            u.Tanım.UrunAdet = Convert.ToInt32(sayac1.Value);
            lblTutar.Text = u.Tanım.tutarhesapla().ToString() + " TL";
            btnSepeteEkle.Enabled = true;
        }

        private void lbKiyafetT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbKiyafetT.SelectedItem == null)
            {
                btnHesapla.Enabled = false;
            }
            else
            {
                sayac1.Value = 1;
                Urun u = (Urun)lbKiyafetT.SelectedItem;
                sayac1.Maximum = u.Tanım.UrunAdet;
                btnHesapla.Enabled = true;
            }
        }

        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            Urun u = (Urun)lbKiyafetT.SelectedItem;
            u.Tanım.UrunAdet = Convert.ToInt32(sayac1.Value);
            Dikim.UrunEkle(u);
            lbSepet.Items.Add(u.Tanım.UrunAdi + " " + u.Tanım.UrunFiyati + " x " + u.Tanım.UrunAdet + " = " + u.Tanım.tutarhesapla().ToString() + " TL");
            lblTutar.Text = "    ";
            lbKiyafetT.SelectedItem = null;
            sayac1.Value = 1;
            btnSepeteEkle.Enabled = false;
            GeciciTutar += u.Tanım.UrunFiyati * u.Tanım.UrunAdet;
        }

        private void btnGenel_Click(object sender, EventArgs e)
        {
            
            int urunsayisi = 0;
            int iücreti;
            urunsayisi = lbSepet.Items.Count;           
            iücreti= urunsayisi * 20;
            GeciciTutar = GeciciTutar + iücreti;
            lblGenel.Text = "İşçilik Dahil " + GeciciTutar.ToString() + " TL";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dikim.AlinanUrunler.Clear();
            Satis.Tarih = DateTime.Now;
            string mesaj = "";
            string[] veriler1 = new string
                [lbSepet.Items.Count];
            for (int i = 0; i < lbSepet.Items.Count; i++)
            {
                veriler1[i] = lbSepet.Items[i].ToString();
                mesaj += veriler1[i] +



                    "  ";
            }
            MessageBox.Show("\n--------------------------------------" +
                                  "\nSipariş Başarıyla Onaylandı" +
                             "\n-------------------------------------" +
                                  "\nJson Uzantısı Oluşturuldu" +
                             "\n-------------------------------------");
            var dateString = DateTime.Now.ToString("MM/dd/yyyy");
            string strResultJson = JsonConvert.SerializeObject(mesaj);
            File.WriteAllText(dateString + ".json", strResultJson);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GeciciTutar = 0;
            if (Application.OpenForms[0] == this)
            {
                Application.Restart();
            }
            else
            {
                Form2 f = new Form2();
                f.Show();
                this.Close();

            }
        }
    }
}
