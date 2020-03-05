using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPaS2.Behaviors
{
    /// <summary>
    /// Интерфейс кряканья утки. Осуществляет "кря".
    /// </summary>
    interface IQuackable
    {
        /// <summary>
        /// Крякнуть (сделать "кря").
        /// </summary>
        void Quack();
    }
}
