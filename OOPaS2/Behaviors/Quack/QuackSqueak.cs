using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPaS2.Behaviors.Quack
{
    /// <summary>
    /// Определяет кряк утки как писк.
    /// </summary>
    class QuackSqueak : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("The Duck goes squeak!");
        }
    }
}
