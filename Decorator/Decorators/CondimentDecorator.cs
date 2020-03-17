using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.Beverages;

namespace Decorator
{

    public abstract class CondimentDecorator : Beverage
    {
        protected Type[] suitableBeverages;

        protected Beverage InnerBeverage;

        public override double GetCost()
        {
            return Cost + InnerBeverage.GetCost();
        }

        public override string GetDescription()
        {
            Dictionary<string, int> orderList = new Dictionary<string, int>();
            CondimentDecorator bufferDecorator = this;
            string bufferName;
            while (bufferDecorator.InnerBeverage is CondimentDecorator inner)
            {
                bufferName = bufferDecorator.Description;
                if (!orderList.ContainsKey(bufferName))
                    orderList.Add(bufferName, 0);
                orderList[bufferName]++;
                bufferDecorator = inner;
            }
            bufferName = bufferDecorator.Description;
            if (!orderList.ContainsKey(bufferName))
                orderList.Add(bufferName, 0);
            orderList[bufferName]++;
            return $"{bufferDecorator.InnerBeverage.GetDescription()}, {string.Join(", ", orderList.Select(row => $"{(countToStr.ContainsKey(row.Value) ? countToStr[row.Value] : row.Value.ToString())} {row.Key}"))}";
        }

        private static readonly Dictionary<int, string> countToStr = new Dictionary<int, string>
        {
            {1,"" },
            {2,"Double" },
            {3,"Triple" },
            {4,"Quadruple" },
            {5,"Quintuple" },
            {6,"Sextuple" },
            {7,"Septuple" },
            {8,"Octuple" },
        };


        protected CondimentDecorator(double basePrice, double multiplier, string description, Beverage source) : base(basePrice, multiplier, description)
        {
            foreach (Type type in suitableBeverages)
                if (type.IsInstanceOfType(source))
                {
                    InnerBeverage = source;
                    break;
                }
            if (InnerBeverage is null)
                throw new InvalidOperationException("Wrong condiment!");
        }
    }
}
