using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPaS2.Behaviors.Fly
{
    /// <summary>
    /// Определяет полет утки при помощи крыльев.
    /// </summary>
    public class FlyWithWings : IFlying
    {
        public void Fly()
        {
            Console.WriteLine("This duck has wings! It flew!");
        }
    }
}
