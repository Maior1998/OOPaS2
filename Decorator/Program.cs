using System;
using Decorator.Beverages;
using Decorator.Coffee;
using Decorator.Condiments;
using Decorator.Tea;

namespace Decorator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Beverage test = new DarkRoast();
            test = new Milk(test);
            test = new Milk(test);
            test = new Mocha(test);
            test = new Soy(test);
            test = new Soy(test);
            test = new Milk(test);
            test = new Milk(test);
            Beverage tea = new ColdTea();
            test = new Caramel(tea);
            Console.WriteLine();
        }
    }
}