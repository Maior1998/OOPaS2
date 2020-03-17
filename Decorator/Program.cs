using System;
using Decorator.Beverages;
using Decorator.Coffee;
using Decorator.Condiments;

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
            test = new Caramel(test);
            Console.WriteLine();
        }
    }
}