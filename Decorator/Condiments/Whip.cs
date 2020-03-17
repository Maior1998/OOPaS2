using Decorator.Beverages;

namespace Decorator.Condiments
{
    public class Whip : CondimentDecorator
    {
        public Whip(double multiplier, Beverage source) : base(0.2, multiplier, source)
        {
            Cost = 0.2;
            Description = "Whip";
        }
    }
}
