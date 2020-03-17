using System;
using OOPaS2.Behaviors.Fly;
using OOPaS2.Behaviors.Quack;
using OOPaS2.Behaviors.Swim;

namespace OOPaS2.Ducks
{
    /// <summary>
    ///     Представляет собой класс утки, содержащий поля и методы, которыми оперируют все утки.
    /// </summary>
    public abstract class Duck : DuckTales.DuckTales
    {
        /// <summary>
        ///     Определяет поведение утки при полете.
        /// </summary>
        private protected IFlying FlyBehavior;

        /// <summary>
        ///     Определяет поведение утки при крякании.
        /// </summary>
        private protected IQuackable QuackBehavior;

        /// <summary>
        ///     Определяет поведение утки при плавании.
        /// </summary>
        private protected ISwimming SwimBehavior;

        /// <summary>
        ///     Название этого типа уток.
        /// </summary>
        public string Name { get; protected set; }

        /// <summary>
        ///     Отображает текущую утку на экране.
        /// </summary>
        public void Display()
        {
            Console.WriteLine($"{Name} appears on the screen!");
        }

        /// <summary>
        ///     Осуществляет кряканье текущей утки в соответствии с её поведением <see cref="QuackBehavior" />.
        /// </summary>
        public void DoQuack()
        {
            QuackBehavior.Quack();
        }

        /// <summary>
        ///     Осуществляет полет текущей утки в соответствии с её поведением <see cref="FlyBehavior" />.
        /// </summary>
        public void DoFly()
        {
            FlyBehavior.Fly();
        }

        /// <summary>
        ///     Осуществляет полет текущей утки в соответствии с её поведением <see cref="SwimBehavior" />.
        /// </summary>
        public void DoSwim()
        {
            SwimBehavior.Swim();
        }


        public override string ToString()
        {
            return Name;
        }
    }
}