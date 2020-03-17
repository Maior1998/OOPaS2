using System;

namespace OOPaS2.Behaviors.Swim
{
    /// <summary>
    ///     Определяет стандартное плавание утки.
    /// </summary>
    public class SwimDefault : ISwimming
    {
        public void Swim()
        {
            Console.WriteLine("This Duck swimming as usual.");
        }
    }
}