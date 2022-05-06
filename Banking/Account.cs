using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    internal class Account
    {
        //Properties
        private static int NextID = 1;
        public int AcctNbr { get; private set; } = 0;
        public string Name { get; set; } = string.Empty;
        public decimal Balance { get; private set; } = 0;

        //Methods
        public bool Deposit(decimal Amount)
        {
            if (Amount <= 0)
            {
                Console.WriteLine("Amount must be greater than 0");
                return false;
            }
            Balance = Balance + Amount;
            return true;
        }

        public bool Withdrawal(decimal Amount)
        {
            if (Amount <= 0)
            {
                Console.WriteLine("Amount must be greater than 0");
                return false;
            }
            if (Amount > Balance)
            {
                Console.WriteLine("Insuficient Funds");
                return false;
            }
            Balance = Balance - Amount;
            return true;
        }
        
        public bool Transfer(decimal Amount, Account ToAccount)
        {
            var success = Withdrawal(Amount);
            if (success)
            {
                ToAccount.Deposit(Amount);
                return true;
            }
            return false;
        }

        //constructors
        public Account()
        {
            AcctNbr = NextID++;
        }
    }
}
