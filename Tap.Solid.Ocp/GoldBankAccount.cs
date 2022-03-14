using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tap.Solid.Ocp
{
    internal class GoldBankAccount:BankAccount
    {
        public GoldBankAccount(decimal initialBalance, AccountType accountType) : base(initialBalance, accountType)
        {

        }

        public override void ExtractMoney(decimal value)
        {
            var comision = 0m;
            comision = value * 0.01m;
            AccountBalance = AccountBalance - (value + comision);

        }
    }
}
