using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPaS2.Behaviors;

namespace OOPaS2.Ducks
{
    /// <summary>
    /// Представляет собой класс утки, содержащий поля и методы, которыми оперируют все утки.
    /// </summary>
    public abstract class Duck
    {
        private IQuacking QuackBehavior;
        private ISwimming SwimBehavior;
        private IFlying FlyBehavior;

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
            SwimBehavior.Swimm();
        }

    }
}
