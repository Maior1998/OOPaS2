using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPaS2.Behaviors.Swim
{
    /// <summary>
    /// Определяет стандартное плавание утки.
    /// </summary>
    public class SwimDefault :ISwimming
    {
        public void Swim()
        {
            Console.WriteLine("This Duck swimming as usual.");
        }
    }
}
