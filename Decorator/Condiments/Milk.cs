using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Condiments
{
    public class Milk : CondimentDecorator
    {
        public Milk(Beverage source) : base(source)
        {
            Cost = 0.1;
            Description = "Milk";
        }
    }
}
