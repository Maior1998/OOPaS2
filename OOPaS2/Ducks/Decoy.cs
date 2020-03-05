using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPaS2.Behaviors;

namespace OOPaS2.Ducks
{
    public class Decoy: DuckTales, IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Decoy did \"Quack\".");
        }
    }
}
