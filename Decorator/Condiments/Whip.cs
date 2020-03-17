using System;
using Decorator.Beverages;

namespace Decorator.Condiments
{
    public class Whip : CondimentDecorator
    {
        public Whip(Beverage source, double multiplier = 1) : base(0.2, multiplier, "Whip", source)
        {
            
        }
        protected override Type[] suitableBeverages => new[] { typeof(Beverages.Coffee) };
    }
}
