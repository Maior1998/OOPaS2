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
        
        public Milk(double multiplier,Beverage source) : base(0.1,multiplier,source)
        {
            suitableBeverages = new[]
            {
                typeof(DarkRoast),
            };
            Cost = 0.1;
            Description = "Milk";
        }
    }
}
