using Banking;

var sav1 = new SavingsComp();
sav1.Name = "My Savings";

sav1.Deposit(100);
sav1.PayInterest(8);
Console.WriteLine(sav1.Name);
Console.WriteLine(sav1.Balance);



//Instances 
//var acct1 = new Account()
//{
//    Name = "Checkings",
//};

//var acct2 = new Account()
//{
//    Name = "Savings"
//};

//acct1.Deposit(1000);
//acct2.Deposit(500);

//acct1.Withdrawal(200);
//acct2.Withdrawal(50);

//Console.WriteLine($"Acct1 balance is {acct1.Balance:c}, Acct2 balance is {acct2.Balance:c}");


//acct1.Withdrawal(1000);
//Console.WriteLine($"Acct1 balance is {acct1.Balance:c}, Acct2 balance is {acct2.Balance:c}");


//acct2.Transfer(100, acct1); 
//Console.WriteLine($"Acct1 balance is {acct1.Balance:c}, Acct2 balance is {acct2.Balance:c}");
