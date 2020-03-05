using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Condiments
{
    public class Mocha : CondimentDecorator
    {
        public Mocha(Beverage Source) : base(Source)
        {
            Cost = 0.2;
            Description = "Mocha";
        }
    }
}
