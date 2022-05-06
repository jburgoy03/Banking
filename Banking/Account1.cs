//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Banking
//{
//    internal class Account1
//    {
//        private static int NextId = 1;
//        public int AcctNbr { get; private set; } = 0;
//        public string AcctName { get; set; } = string.Empty;
//        public decimal Balance { get; private set; } = 0;

//        public bool Deposit(decimal amount)
//        {
//            if (amount <= 0)
//            {
//                Console.WriteLine("Deposit must be greater than 0");
//            }
//            Balance = Balance + amount;
//            return true;
//        }
//        public bool Withdrawal(decimal Amount)
//        {
//            if (Amount <= 0)
//            {
//                Console.WriteLine("Deposit must be greater than 0");
//            }
//            if (Amount > Balance)
//            {
//                Console.WriteLine("Withdrawal is greater than the balance");
//            }
//            Balance = Balance - Amount;
//            return true;
//        }
//        public bool Transfer(decimal Amount, Account ToAccount)
//        {
//            var success = Withdrawal(Amount);
//            if (success)
//            {
//                ToAccount.Deposit(Amount);
//                return true;
//            }
//            return false;        
//        }
//          public Account1()
//        {
//            AcctNbr = NextId; 
//        }
//    }
//}
