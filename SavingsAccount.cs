using System;

class SavingsAccount : BankAccount
{
  //Features
  
  //Parameters
 public override double Balance { 
  get{ return balance; } 
  set{
  if (value >= 2500.00)
    balance = value;
  else
  Console.WriteLine ("The Balance cannot be less than $2500.");
  }
  }

  //Constructor
  public SavingsAccount() : base()
  {
    Console.WriteLine("Savings Account constructor");
  }

  //Constructor with parameters
  public SavingsAccount(string accountnumber, string name, double balance) : base (accountnumber, name, balance)
  {
    Console.WriteLine("Savings Account constructor");

  }

 //Methods
 
  public void CalculateInterest(){
    Balance = Balance + (Balance * .05); 
    Console.WriteLine ("Added interest and updated Balance.");
  }

  public override void Withdrawl(double amount)
  {
  if (Balance >= 2500.00)
    base.Withdrawl(amount);
  else
      Console.WriteLine ("Insufficient balance.");

}


}