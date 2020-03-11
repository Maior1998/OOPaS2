using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Condiments
{
    public class Soy: CondimentDecorator
    {
        public Soy(Beverage source) : base(source)
        {
            Cost = 0.3;
            Description = "Soy";
        }
    }
}
