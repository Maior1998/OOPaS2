using System;
using Decorator.Beverages;

namespace Decorator.Condiments
{
    public class Caramel : CondimentDecorator
    {
        public Caramel(Beverage source, double multiplier = 1) : base(0.2, multiplier, "Caramel", source)
        {
        }

        protected override Type[] suitableBeverages => new[] {typeof(Beverages.Tea)};
    }
}