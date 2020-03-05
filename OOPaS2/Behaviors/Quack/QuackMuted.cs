using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPaS2.Behaviors.Quack
{
    /// <summary>
    /// Определяет крякание утки, которая не может крякать, а точнее отсутствие этого крякания.
    /// </summary>
    class QuackMuted :IQuackable
    {
        public void Quack()
        {
            Console.WriteLine($"Omg, this duck can't do \"quack\"!");
        }
    }
}
