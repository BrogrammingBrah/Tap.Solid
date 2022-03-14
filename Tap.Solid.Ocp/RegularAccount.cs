using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tap.Solid.Ocp
{
    internal class RegularAccount
    {
        public decimal ExtractMoney(decimal value)
        {
            return value * 0.02m;
        }
    }
}
