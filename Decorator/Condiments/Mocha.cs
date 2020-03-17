using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.Beverages;

namespace Decorator.Condiments
{
    public class Mocha : CondimentDecorator
    {
        public Mocha(Beverage source, double multiplier=1) : base(0.2, multiplier, "Milk", source)
        {
            
        }

        protected override Type[] suitableBeverages => new[] { typeof(Beverages.Coffee) };
    }
}
