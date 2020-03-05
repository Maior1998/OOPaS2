using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{

    public abstract class CondimentDecorator : Beverage
    {
        protected Beverage InnerBeverage;

        protected CondimentDecorator(Beverage Source)
        {
            InnerBeverage = Source;
        }

        public override double GetCost()
        {
            return Cost + InnerBeverage.GetCost();
        }

        public override string GetDescription()
        {
            Dictionary<string, int> OrderList = new Dictionary<string, int>();
            CondimentDecorator BufferDecorator = this;
            string BufferName;
            while (BufferDecorator.InnerBeverage is CondimentDecorator Inner)
            {
                BufferName = BufferDecorator.Description;
                if (!OrderList.ContainsKey(BufferName))
                    OrderList.Add(BufferName, 0);
                OrderList[BufferName]++;
                BufferDecorator = Inner;
            }
            BufferName = BufferDecorator.Description;
            if (!OrderList.ContainsKey(BufferName))
                OrderList.Add(BufferName, 0);
            OrderList[BufferName]++;
            return $"{BufferDecorator.InnerBeverage.GetDescription()}, {string.Join(", ", OrderList.Select(row => $"{(CountToStr.ContainsKey(row.Value) ? CountToStr[row.Value] : row.Value.ToString())} {row.Key}"))}";
        }

        private static readonly Dictionary<int, string> CountToStr = new Dictionary<int, string>
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
    }
}
