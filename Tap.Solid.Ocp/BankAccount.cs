namespace Tap.Solid.Ocp
{
    public abstract class BankAccount
    {
        public decimal AccountBalance { get; private set; }
        public AccountType AccountType { get; private set; }

        public BankAccount(decimal initialBalance, AccountType accountType)
        {
            AccountBalance = initialBalance;
            AccountType = accountType;
        }
         public abstract void ExtractMoney(decimal value);

        /*       public void ExtractMoney(decimal value)
               {
                   var commision = 0m;

                   if(AccountType == AccountType.Regular)
                   {
                       commision = value * 0.02m;
                   }

                   if (AccountType == AccountType.Gold)
                   {
                       commision = value * 0.01m;
                   }

                   AccountBalance = AccountBalance - (value + commision);
               }
          */

        public interface IBankAccount
        {
            BankAccount ExtractMoney(decimal value);
        }

        public class RegularAccount:IBankAccount
        {
                BankAccount IBankAccount.ExtractMoney(decimal value)
                {
                    var commision = 0m;
                    commision = value * 0.02m;
                    AccountBalance = AccountBalance - (value + commision);
                }
            
        }
        


    }
}
