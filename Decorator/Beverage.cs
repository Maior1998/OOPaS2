using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class Beverage
    {

        /// <summary>
        /// Описание базового компонента.
        /// </summary>
        public string Description;

        public double Cost;

        /// <summary>
        /// Возвращает описание текущего компонента или их набора.
        /// </summary>
        /// <returns>Строка - описание текущего компонента или их набора.</returns>
        public virtual string GetDescription()=>Description;

        /// <summary>
        /// Возвращает текущую стоимость данного компонента или их набора.
        /// </summary>
        /// <returns>Число - текущая стоимость данного компонента или их набора.</returns>
        public virtual double GetCost() => Cost;

        public override string ToString()
        {
            return $"{GetDescription()} ({GetCost()})";
        }
    }
}
