using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.Beverages;
using Decorator.Coffee;

namespace Decorator.Condiments
{
    public class Milk : CondimentDecorator
    {
        
        public Milk(Beverage source, double multiplier = 1) : base(0.1,multiplier,"Milk",source)
        {
        }

        protected override Type[] suitableBeverages => new[] { typeof(Beverages.Coffee) };
    }
}
