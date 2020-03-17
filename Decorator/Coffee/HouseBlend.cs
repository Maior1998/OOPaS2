namespace Decorator.Coffee
{
    public class HouseBlend : Beverages.Coffee
    {
        public HouseBlend(double multiplier = 1) : base(0.4, multiplier, "House Blend")
        {
        }
    }
}