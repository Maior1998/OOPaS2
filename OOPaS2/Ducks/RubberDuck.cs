﻿using OOPaS2.Behaviors.Fly;
using OOPaS2.Behaviors.Quack;
using OOPaS2.Behaviors.Swim;

namespace OOPaS2.Ducks
{
    /// <summary>
    ///     Определяет резиновую утку.
    /// </summary>
    public class RubberDuck : Duck
    {
        /// <summary>
        ///     Инициализирует новый объект резиновой утки.
        /// </summary>
        public RubberDuck()
        {
            QuackBehavior = new QuackSqueak();
            FlyBehavior = new FlyNoWay();
            SwimBehavior = new SwimAdrift();
            Name = "Rubber Duck";
        }
    }
}