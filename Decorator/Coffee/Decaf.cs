using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.Beverages;

namespace Decorator.Coffee
{
    class Decaf : Beverages.Coffee
    {
        public Decaf(double multiplier=1) : base(0.2, multiplier, "Decaf")
        {
        }

    }
}
