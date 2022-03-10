using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tap.Solid.Srp
{
    internal class SocialSecurityNumber_Length:Student
    {
      

        public bool SocialSecurityNumber_is_valid()
        {
            if (SocialSecurityNumber.Length != 13)
            {
                Console.WriteLine("Invalid social security number!");
                return false;
            }
            else
                return true;
        }
    }
}
