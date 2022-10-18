using System;
using System.Collections.Generic;
using System.Text;

namespace Terzi
{
    public class İscilik : Odeme
    {

        private const decimal İscilikorani = 30;
        public decimal İscilik1 { get; private set; }
        public int UrunSayisi { get; set; }
        public override void Ode(decimal tutar)
        {
           
            İscilik1 = UrunSayisi * İscilikorani;
            OdemeMiktari = tutar + İscilik1;
        }
    }
}
