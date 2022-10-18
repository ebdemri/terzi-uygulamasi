using System;
using System.Collections.Generic;
using System.Text;

namespace Terzi
{
    public class Dukkan
    {       
        public List<Urun> UrunListesi { get; set; }
        public string DukkanAdi { get; set; }        

        
        public void UrunEkle (Urun u)
        {
            bool x = true;
            foreach(Urun ur in UrunListesi)
            {
                if (ur.Tanım.UrunAdi == u.Tanım.UrunAdi) 
                {
                    x = false;
                    ur.Tanım.UrunAdet = ur.Tanım.UrunAdet + u.Tanım.UrunAdet;
                }
            }
            if (x==true)
            {
                UrunListesi.Add(u);
                x = true;          
            }
        }
        
        public string UrunListele()
        {
            string urun = "";
            foreach (Urun u in UrunListesi)
            {
                {
                    urun += " Ürün Kodu:   " + u.Tanım.UrunKodu.ToString() +
                            " Ürün Adı:    " + u.Tanım.UrunAdi +
                            " Ürün Fiyatı: " + u.Tanım.UrunFiyati.ToString();
                }
            }
            return urun;
        }
        public Dukkan()
        {
            this.DukkanAdi = "Terzihane";
            this.UrunListesi = new List<Urun>();
                       
            Urun U1 = new Urun();
            Urun U2 = new Urun();
            Urun U3 = new Urun();
            Urun U4 = new Urun();
            Urun U5 = new Urun();
            Urun U6 = new Urun();
            Urun U7 = new Urun();
            Urun U8 = new Urun();
            Urun U9 = new Urun();
            Urun U10 = new Urun();

            U1.Tanım.UrunKodu = 001;            
            U1.Tanım.UrunAdi = "Gömlek";
            U1.Tanım.UrunFiyati = 120;            
            UrunListesi.Add(U1);

            U2.Tanım.UrunKodu = 002;            
            U2.Tanım.UrunAdi = "Ceket";
            U2.Tanım.UrunFiyati = 465;          
            UrunListesi.Add(U2);

            U3.Tanım.UrunKodu = 003;            
            U3.Tanım.UrunAdi = "Kaban";
            U3.Tanım.UrunFiyati = 700;           
            UrunListesi.Add(U3);

            U4.Tanım.UrunKodu = 004;           
            U4.Tanım.UrunAdi = "T-shirt";
            U4.Tanım.UrunFiyati = 90;            
            UrunListesi.Add(U4);

            U5.Tanım.UrunKodu = 005;            
            U5.Tanım.UrunAdi = "Kravat";
            U5.Tanım.UrunFiyati = 50;            
            UrunListesi.Add(U5);

            U6.Tanım.UrunKodu = 006;           
            U6.Tanım.UrunAdi = "Pantolon";
            U6.Tanım.UrunFiyati = 120;            
            UrunListesi.Add(U6);

            U7.Tanım.UrunKodu = 007;
            U7.Tanım.UrunAdi = "Gelinlik";
            U7.Tanım.UrunFiyati = 2000;
            UrunListesi.Add(U7);

            U8.Tanım.UrunKodu = 008;
            U8.Tanım.UrunAdi = "Takım Elbise";
            U8.Tanım.UrunFiyati = 1500;           
            UrunListesi.Add(U8);

            U9.Tanım.UrunKodu = 009;
            U9.Tanım.UrunAdi = "Etek";
            U9.Tanım.UrunFiyati = 100;           
            UrunListesi.Add(U9);

            U10.Tanım.UrunKodu = 010;
            U10.Tanım.UrunAdi = "Mont";
            U10.Tanım.UrunFiyati = 500;            
            UrunListesi.Add(U10);

        }
    }
}
