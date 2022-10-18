using System;
using System.Collections.Generic;
using System.Text;

namespace Terzi
{
    public class Satis
    {
        public DateTime Tarih { get; set; }
        public Dikim Satiskalemi = new Dikim();
        public decimal ToplamTutar { get; set; }

        public İscilik İscilik1 = new İscilik();
        
    }
}
