using System;
using OOPaS2.Behaviors.Fly;
using OOPaS2.Behaviors.Quack;
using OOPaS2.Behaviors.Swim;

namespace OOPaS2.Ducks
{
    /// <summary>
    /// Определяет маллардскую утку.
    /// </summary>
    public class MallardDuck : Duck
    {
        /// <summary>
        /// Инициализирует новый объект маллардской утки.
        /// </summary>
        public MallardDuck()
        {
            QuackBehavior = new QuackDefault();
            FlyBehavior = new FlyWithWings();
            SwimBehavior= new SwimDefault();
        }

        public override string Name { get; protected set; } = "Mallard Duck";
        
    }
}
