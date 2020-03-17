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
        public Espresso(double basePrice, double multiplier) : base(basePrice, multiplier)
        {
            Description = "Espresso";
        }

    }
}
