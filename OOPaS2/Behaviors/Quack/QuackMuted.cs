using System;

namespace OOPaS2.Behaviors.Quack
{
    /// <summary>
    ///     Определяет крякание утки, которая не может крякать, а точнее отсутствие этого крякания.
    /// </summary>
    internal class QuackMuted : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Omg, this duck can't do \"quack\"!");
        }
    }
}