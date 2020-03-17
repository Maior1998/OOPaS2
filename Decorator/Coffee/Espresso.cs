namespace Decorator.Coffee
{
    internal class Espresso : Beverages.Coffee
    {
        public Espresso(double multiplier = 1) : base(0.3, multiplier, "Espresso")
        {
        }
    }
}