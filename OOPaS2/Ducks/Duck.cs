using OOPaS2.Behaviors.Fly;
using OOPaS2.Behaviors.Quack;
using OOPaS2.Behaviors.Swim;

namespace OOPaS2.Ducks
{
    /// <summary>
    /// Представляет собой класс утки, содержащий поля и методы, которыми оперируют все утки.
    /// </summary>
    public abstract class Duck : DuckTales.DuckTales
    {
        private protected IQuackable QuackBehavior;
        private protected ISwimming SwimBehavior;
        private protected IFlying FlyBehavior;

        /// <summary>
        /// Отображает текущую утку на экране.
        /// </summary>
        public abstract void Display();

        /// <summary>
        /// Осуществляет кряканье текущей утки в соответствии с её поведением <see cref="QuackBehavior"/>.
        /// </summary>
        public void DoQuack()
        {
            QuackBehavior.Quack();
        }

        /// <summary>
        /// Осуществляет полет текущей утки в соответствии с её поведением <see cref="FlyBehavior"/>.
        /// </summary>
        public void DoFly()
        {
            FlyBehavior.Fly();
        }

        /// <summary>
        /// Осуществляет полет текущей утки в соответствии с её поведением <see cref="SwimBehavior"/>.
        /// </summary>
        public void DoSwimm()
        {
            SwimBehavior.Swim();
        }

    }
}
