using System;

namespace OOPaS2.Behaviors.Quack
{
    /// <summary>
    ///     Определяет кряк утки как писк.
    /// </summary>
    internal class QuackSqueak : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("The Duck goes squeak!");
        }
    }
}