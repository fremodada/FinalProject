using System;

class MainClass {
  public static void Main (string[] args) {
  
  // TEST 1: Call Bank Account constructor with no parameters  
  Console.WriteLine("TEST 1");
  BankAccount account1 = new BankAccount();
  account1.DisplayAccountInfo();
  Console.WriteLine("\n");
  
  // TEST 2: Call Bank Account constructor with paramaters  
  Console.WriteLine("TEST 2");
  BankAccount account2 = new BankAccount("123456","Hank Scorpio", 2000.50);
  account2.DisplayAccountInfo();
  Console.WriteLine(account2.DateCreated);
  Console.WriteLine("\n");

  /* TEST 3: Negative test paramaters
  Account Number <> 6 characters long
  Balance that is negative
  */
  Console.WriteLine("TEST 3");
  BankAccount account3 = new BankAccount("12345","Hank Scorpio", -2000.50);
  account3.DisplayAccountInfo();
  Console.WriteLine("\n");

  // TEST 4: Try to set DateCreated in future.  This is done by setting the value of Date Created to one day from Now.
  Console.WriteLine("TEST 4");
  BankAccount accountFuture = new BankAccount("202000","Charles Xavier", 2000.00);
  accountFuture.DateCreated = DateTime.Now.AddDays(1);
  Console.WriteLine(accountFuture.DateCreated);
  Console.WriteLine("\n");

  // TEST 5: Deposit Amount
  Console.WriteLine("TEST 5");
  account2.Deposit(500.00);
  Console.WriteLine(account2.Balance);
  Console.WriteLine("\n");

  // TEST 6: Withdrawl Amount
  Console.WriteLine("TEST 6");
  account2.Withdrawl(250.00);
  Console.WriteLine(account2.Balance);
  Console.WriteLine("\n");

  // TEST 7: Attempt to withdrawl more than what is in Balance
  Console.WriteLine("TEST 7");
  account2.Withdrawl(20000.00);
  account2.DisplayAccountInfo();
  Console.WriteLine("\n");
  
  // TEST 8: Call Savings Account constructor
    Console.WriteLine("TEST 8");
  SavingsAccount account4 = new SavingsAccount();
  account4.DisplayAccountInfo();
  Console.WriteLine("\n");

  // TEST 9: Call Savings Account constructor with parameters
    Console.WriteLine("TEST 9");
  SavingsAccount account5 = new SavingsAccount("987154","Montgomery Burns", 3000.00);
  account5.DisplayAccountInfo();
  Console.WriteLine("\n");

  // TEST 10: Savings Account Balance cannot be less than $2500
  Console.WriteLine("TEST 10");
  SavingsAccount account6 = new SavingsAccount("987654","Montgomery Burns", 2499.00);
  account6.DisplayAccountInfo();
  Console.WriteLine("\n");

  // TEST 11: Add interest to Savings Account Balance
  Console.WriteLine("TEST 11");
  account5.CalculateInterest();
  account5.DisplayAccountInfo();
  Console.WriteLine("\n");
  
  // TEST 12: Attempt Savings Account withdrawl, with Balance >= 2500
  Console.WriteLine("TEST 12");
SavingsAccount account7 = new SavingsAccount("900000","Troy McClure", 3000.00);
  account7.DisplayAccountInfo();
  account7.Withdrawl(500.00);
  account7.DisplayAccountInfo();
  Console.WriteLine("\n");

  // TEST 13: Attempt Savings Account withdrwal, with amount to withdrawl > Balance
    Console.WriteLine("TEST 13");
account7.DisplayAccountInfo();
  account7.Withdrawl(10000.00);
  account7.DisplayAccountInfo();
  Console.WriteLine("\n");

   // TEST 14: Attempt Savings Account withdrawl, with Balance = $2500
    Console.WriteLine("TEST 14");
account7.DisplayAccountInfo();
  account7.Withdrawl(10.00);
  account7.DisplayAccountInfo();
  Console.WriteLine("\n");

  // TEST 15: Checking Account constructor with no paramaters
    Console.WriteLine("TEST 15");
CheckingAccount account8 = new CheckingAccount();
  account8.DisplayAccountInfo();
  Console.WriteLine("\n");

  // TEST 16: Call Checking Account constructor with parameters
    Console.WriteLine("TEST 16");
CheckingAccount account9 = new CheckingAccount("911111","Shiv Palpatine", 3000.00);
  account9.DisplayAccountInfo();
  Console.WriteLine("\n");

  // TEST 17: Checking Account Balance cannot be less than $500
    Console.WriteLine("TEST 17");
CheckingAccount account10 = new CheckingAccount("987654","Hal Jordan", 499.00);
  account10.DisplayAccountInfo();
  Console.WriteLine("\n");

  // TEST 18: Add interest to Checking Account Balance
    Console.WriteLine("TEST 18");
account9.CalculateInterest();
  account9.DisplayAccountInfo();
  Console.WriteLine("\n");

  // TEST 19: Attempt Checking Account withdrawl, with Balance >= 500
    Console.WriteLine("TEST 19");
CheckingAccount account11 = new CheckingAccount("900000","Troy McClure", 600.00);
  account11.DisplayAccountInfo();
  account11.Withdrawl(100.00);
  account11.DisplayAccountInfo();
  Console.WriteLine("\n");

  // TEST 20: Attempt Savings Account withdrwal, with amount to withdrawl > Balance
  Console.WriteLine("TEST 20");
  account11.DisplayAccountInfo();
  account11.Withdrawl(1000.00);
  account11.DisplayAccountInfo();
  Console.WriteLine("\n");

   // TEST 21: Attempt Savings Account withdrawl, with Balance = $500
  Console.WriteLine("TEST 21");
  account11.DisplayAccountInfo();
  account11.Withdrawl(10.00);
  Console.WriteLine("\n");



  }
}