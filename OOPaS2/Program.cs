using System;
using OOPaS2.Ducks;
using OOPaS2.DuckTales;

namespace OOPaS2
{
    class Program
    {
        private static readonly DuckTales.DuckTales[] ducks=
        {
            new MallardDuck(), 
            new RedheadDuck(), 
            new RubberDuck(), 
            new RoastDuck(), 
            new Decoy(), 
        };

        static void Main(string[] args)
        {
            foreach (DuckTales.DuckTales duckTale in ducks)
            {
                Console.WriteLine();
                switch (duckTale)
                {
                    case Duck currentDuck:
                        currentDuck.Display();
                        currentDuck.DoQuack();
                        currentDuck.DoFly();
                        currentDuck.DoSwim();
                        break;
                    case Decoy currentDecoy:
                        currentDecoy.DoQuack();
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
