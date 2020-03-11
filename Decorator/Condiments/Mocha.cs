using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Condiments
{
    public class Mocha : CondimentDecorator
    {
        public Mocha(Beverage source) : base(source)
        {
            Cost = 0.2;
            Description = "Mocha";
        }
    }
}
