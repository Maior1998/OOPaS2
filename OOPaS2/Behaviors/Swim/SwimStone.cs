using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPaS2.Behaviors.Swim
{
    /// <summary>
    /// Определяет плавание утки примерно на уровне топора, то есть никак.
    /// </summary>
    public class SwimLikeStone : ISwimming
    {
        public void Swim()
        {
            Console.WriteLine("This Duck can no more swim than a hammer can.");
        }
    }
}
