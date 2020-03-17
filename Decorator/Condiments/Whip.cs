using Decorator.Beverages;

namespace Decorator.Condiments
{
    public class Whip: CondimentDecorator
    {
        public Whip(Beverage source) : base(source)
        {
            Cost = 0.2;
            Description = "Whip";
        }
    }
}
