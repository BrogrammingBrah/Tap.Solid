using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tap.Solid.Srp
{
    public class Email_Validator
    {
        public String email { get; set; }
        public bool Is_Email_Valid()
        {
            if (!email.Contains("@uaic.ro"))
            {
                Console.WriteLine("Invalid email. Please use your uaic email!");
                return false;
            }
            else return true;
        }
    }
}
