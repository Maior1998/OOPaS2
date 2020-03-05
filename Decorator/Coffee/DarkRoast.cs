using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Coffee
{
    class DarkRoast : Beverage
    {
        public DarkRoast(double basePrice, double multiplier)
        {
            Cost = basePrice * multiplier;
            Description = "Dark Roast";
        }

    }
}
