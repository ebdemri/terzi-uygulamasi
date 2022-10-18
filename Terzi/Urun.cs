using System;
using System.Collections.Generic;
using System.Text;

namespace Terzi
{
    public class Urun
    {
        public UrunTanim Tanım = new UrunTanim();
        public UrunTanim KTanim = new UrunTanim();

        public override string ToString()
        {
            return string.Format("{0}-{1} {2}", Tanım.UrunAdi, Tanım.UrunFiyati, "TL");
        }

    }
}
