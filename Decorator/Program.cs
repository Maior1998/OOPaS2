using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.Coffee;
using Decorator.Condiments;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage test = new DarkRoast(0.5,1);
            test = new Milk(test);
            test = new Milk(test);
            test = new Mocha(test);
            test = new Soy(test);
            test = new Soy(test);
            test = new Milk(test);
            test = new Milk(test);
            Console.WriteLine();
        }
    }
}
