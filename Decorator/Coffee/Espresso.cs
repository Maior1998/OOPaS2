using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Coffee
{
    class Espresso : Beverage
    {
        public Espresso(double basePrice, double multiplier)
        {
            Cost = basePrice * multiplier;
            Description = "Espresso";
        }

    }
}
