using System;
using OOPaS2.Behaviors;
using OOPaS2.Behaviors.Quack;

namespace OOPaS2.DuckTales
{
    /// <summary>
    /// Утиный манок.
    /// </summary>
    public class Decoy: DuckTales
    {
        /// <summary>
        /// Крякнуть утиным манком.
        /// </summary>
        public void Quack()
        {
            Console.WriteLine("Decoy did \"Quack\".");
        }
    }
}
