using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPaS2.Behaviors.Swim
{
    /// <summary>
    /// Определяет инертное плавание утки - она просто плывет по течению.
    /// </summary>
    public class SwimAdrift: ISwimming
    {
        public void Swim()
        {
            Console.WriteLine("This Duck swimming adrift.");
        }
    }
}
