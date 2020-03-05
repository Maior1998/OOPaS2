using System;
using OOPaS2.Ducks;
using OOPaS2.DuckTales;

namespace OOPaS2
{
    class Program
    {
        private static DuckTales.DuckTales[] Ducks=
        {
            new MallardDuck(), 
            new RedheadDuck(), 
            new RubberDuck(), 
            new RoastDuck(), 
            new Decoy(), 
        };

        static void Main(string[] args)
        {
            foreach (DuckTales.DuckTales DuckTale in Ducks)
            {
                Console.WriteLine();
                switch (DuckTale)
                {
                    case Duck CurrentDuck:
                        CurrentDuck.Display();
                        CurrentDuck.DoQuack();
                        CurrentDuck.DoFly();
                        CurrentDuck.DoSwim();
                        break;
                    case Decoy CurrentDecoy:
                        CurrentDecoy.Quack();
                        break;
                    default:
                        Console.WriteLine("Wow, i don't know this type of duck and this is not a decoy! What is this?");
                        break;
                }
            }

            Console.WriteLine();

        }
    }
}
