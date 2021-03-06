﻿using OOPaS2.Behaviors.Fly;
using OOPaS2.Behaviors.Quack;
using OOPaS2.Behaviors.Swim;

namespace OOPaS2.Ducks
{
    /// <summary>
    ///     Определяет деревянную утку.
    /// </summary>
    public class WoodDuck : Duck
    {
        /// <summary>
        ///     Инициализирует новый объект деревянной утки.
        /// </summary>
        public WoodDuck()
        {
            FlyBehavior = new FlyNoWay();
            SwimBehavior = new SwimAdrift();
            QuackBehavior = new QuackMuted();
            Name = "Wood Duck";
        }
    }
}