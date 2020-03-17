using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.Beverages;

namespace Decorator.Coffee
{
    class Espresso : Beverages.Coffee
    {
        public Espresso(double multiplier=1) : base(0.3, multiplier, "Espresso")
        {
        }

    }
}
