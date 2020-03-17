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
        /// Определяет поведение манка при крякании.
        /// </summary>
        private IQuackable quackBehavior;

        /// <summary>
        /// Инициализирует новый объект утиного манка.
        /// </summary>
        public Decoy()
        {
            quackBehavior = new QuackDefault();
        }

        /// <summary>
        /// Крякнуть утиным манком.
        /// </summary>
        public void DoQuack()
        {
            quackBehavior.Quack();
        }
    }
}
