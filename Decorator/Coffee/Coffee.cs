namespace Decorator.Beverages
{
    public abstract class Coffee : Beverage
    {
        protected Coffee(double basePrice, double multiplier, string description) : base(basePrice, description,
            multiplier)
        {
        }
    }
}