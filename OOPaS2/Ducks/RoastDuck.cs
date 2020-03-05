using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPaS2.Behaviors.Fly;
using OOPaS2.Behaviors.Quack;
using OOPaS2.Behaviors.Swim;

namespace OOPaS2.Ducks
{
    /// <summary>
    /// Определяет жареную утку.
    /// </summary>
    public class RoastDuck : Duck
    {
        /// <summary>
        /// Инициализирует новый объект жареной утки.
        /// </summary>
        public RoastDuck()
        {
            FlyBehavior = new FlyNoWay();
            SwimBehavior = new SwimLikeStone();
            QuackBehavior = new QuackMuted();
        }

        public override void Display()
        {
            Console.WriteLine("Rust Duck appears on the screen!");
        }
    }
}
