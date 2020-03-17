using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Beverages
{
    public abstract class Tea : Beverage
    {
        protected Tea(double basePrice, double multiplier, string description) : base(basePrice, description, multiplier)
        {
        }
    }
}
