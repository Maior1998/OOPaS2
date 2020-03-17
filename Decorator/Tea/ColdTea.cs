namespace Decorator.Tea
{
    public class ColdTea : Beverages.Tea
    {
        public ColdTea(double multiplier = 1) : base(0.2, multiplier, "Cold Tea")
        {
        }
    }
}