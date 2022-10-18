using System;
using System.Collections.Generic;
using System.Text;

namespace Terzi
{
    public class Dikim
    {
        public  List<Urun> AlinanUrunler { get; set; }
        public  void UrunEkle(Urun u)
        {
            AlinanUrunler.Add(u);

        }
        public  Dikim()
        {
            AlinanUrunler = new List<Urun>();
        }
    }
}
