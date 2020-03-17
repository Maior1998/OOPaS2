using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.Beverages;

namespace Decorator.Coffee
{
    public class HouseBlend :Beverage
    {
        public HouseBlend(double basePrice, double multiplier)
        {
            Cost = basePrice * multiplier;
            Description = "House Blend";
        }

    }
}
