namespace Decorator.Beverages
{
    public abstract class Tea : Beverage
    {
        protected Tea(double basePrice, double multiplier, string description) : base(basePrice, description,
            multiplier)
        {
        }
    }
}