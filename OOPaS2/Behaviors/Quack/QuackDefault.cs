using System;

namespace OOPaS2.Behaviors.Quack
{
    /// <summary>
    ///     Определяет стандартное крякание утки.
    /// </summary>
    public class QuackDefault : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Duck goes \"quack!\"!");
        }
    }
}