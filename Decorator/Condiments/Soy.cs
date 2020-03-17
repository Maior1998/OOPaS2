using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.Beverages;

namespace Decorator.Condiments
{
    public class Soy: CondimentDecorator
    {
        public Soy(Beverage source, double multiplier = 1) : base(0.3, multiplier, "Soy", source)
        {
            
        }
        protected override Type[] suitableBeverages => new[] { typeof(Beverages.Coffee) };
    }
}
