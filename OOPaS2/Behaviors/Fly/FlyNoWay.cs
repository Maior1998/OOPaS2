using System;

namespace OOPaS2.Behaviors.Fly
{
    /// <summary>
    ///     Определяет полет утки, не умеющей летать, то есть отсутствие этого полета.
    /// </summary>
    public class FlyNoWay : IFlying
    {
        public void Fly()
        {
            Console.WriteLine("This Duck can't fly!");
        }
    }
}