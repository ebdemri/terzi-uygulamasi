using System;
using System.Collections.Generic;
using System.Text;

namespace Terzi
{
    public abstract class Odeme
    {
        public decimal OdemeMiktari { get; set; }

        public abstract void Ode(decimal tutar);
    }
}
