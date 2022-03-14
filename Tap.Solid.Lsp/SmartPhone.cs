using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tap.Solid.Lsp
{
    internal abstract class SmartPhone : MobilePhone
    {
        internal abstract void SendEmail(string emailAdress);
        internal abstract void BrowseWeb(string webAdress);
    }
}
