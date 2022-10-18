using System;
using System.Collections.Generic;
using System.Text;

namespace Terzi
{
    public class UrunKatalogu
    {
        public  Dukkan Dukkan { get; set; }
        public UrunTanim UrunTanimi { get; set; }

        public  UrunKatalogu()
        {
            this.Dukkan = new Dukkan();
        }
    }
}
