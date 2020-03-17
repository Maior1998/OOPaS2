using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Tea
{
    public class ColdTea : Beverages.Tea
    {
        public ColdTea(double multiplier) : base(0.2, multiplier,"Cold Tea")
        {
        }

    }
}
