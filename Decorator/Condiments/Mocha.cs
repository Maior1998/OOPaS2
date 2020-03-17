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
        protected 
        public Mocha(Beverage source) : base(source)
        {
            Cost = 0.2;
            Description = "Mocha";
        }
    }
}
