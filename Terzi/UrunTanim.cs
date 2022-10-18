using System;
using System.Collections.Generic;
using System.Text;

namespace Terzi
{
    public class UrunTanim
    {
        public string UrunTanımi { get; set; }
        public string UrunAdi { get; set; }
        public int UrunKodu { get; set; }
        public decimal UrunFiyati { get; set; }
        public int UrunAdet { get; set; }
        public decimal Tutar { get; set; }       
        public decimal tutarhesapla()
        {

            this.Tutar = this.UrunAdet * this.UrunFiyati;

            return Tutar;
        }
    }
}
