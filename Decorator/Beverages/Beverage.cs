namespace Decorator.Beverages
{
    public abstract class Beverage
    {
        public double Cost;

        /// <summary>
        ///     Описание базового компонента.
        /// </summary>
        public string Description;

        protected Beverage(double basePrice, string description, double multiplier)
        {
            Cost = basePrice * multiplier;
            Description = description;
        }

        /// <summary>
        ///     Возвращает описание текущего компонента или их набора.
        /// </summary>
        /// <returns>Строка - описание текущего компонента или их набора.</returns>
        public virtual string GetDescription()
        {
            return Description;
        }

        /// <summary>
        ///     Возвращает текущую стоимость данного компонента или их набора.
        /// </summary>
        /// <returns>Число - текущая стоимость данного компонента или их набора.</returns>
        public virtual double GetCost()
        {
            return Cost;
        }

        public override string ToString()
        {
            return $"{GetDescription()} (${GetCost()})";
        }
    }
}