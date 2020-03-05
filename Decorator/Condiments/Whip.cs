namespace Decorator.Condiments
{
    public class Whip: CondimentDecorator
    {
        public Whip(Beverage Source) : base(Source)
        {
            Cost = 0.2;
            Description = "Whip";
        }
    }
}
