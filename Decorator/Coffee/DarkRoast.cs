namespace Decorator.Coffee
{
    internal class DarkRoast : Beverages.Coffee
    {
        public DarkRoast(double multiplier = 1) : base(0.3, multiplier, "Dark Roast")
        {
        }
    }
}