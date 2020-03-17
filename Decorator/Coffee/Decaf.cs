namespace Decorator.Coffee
{
    internal class Decaf : Beverages.Coffee
    {
        public Decaf(double multiplier = 1) : base(0.2, multiplier, "Decaf")
        {
        }
    }
}