using OOPaS2.Behaviors.Fly;
using OOPaS2.Behaviors.Quack;
using OOPaS2.Behaviors.Swim;

namespace OOPaS2.Ducks
{
    /// <summary>
    ///     Определяет рыжую утку.
    /// </summary>
    public class RedheadDuck : Duck
    {
        /// <summary>
        ///     Инициализирует новый объект рыжей утки.
        /// </summary>
        public RedheadDuck()
        {
            QuackBehavior = new QuackDefault();
            FlyBehavior = new FlyWithWings();
            SwimBehavior = new SwimDefault();
            Name = "Redhead Duck";
        }
    }
}