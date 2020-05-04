using System;
using Decorator.Beverages;

namespace Decorator.Condiments
{
    public class Mocha : CondimentDecorator
    {
        public Mocha(Beverage source, double multiplier = 1) : base(0.2, multiplier, "Mocha", source)
        {
        }

        protected override Type[] suitableBeverages => new[] {typeof(Beverages.Coffee)};
    }
}