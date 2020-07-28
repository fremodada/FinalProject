using System;

class CheckingAccount : BankAccount
{
  //Features
  
  //Parameters
 public override double Balance { 
  get{ return balance; } 
  set{
  if (value >= 500.00)
    balance = value;
  else
  Console.WriteLine ("The Balance cannot be less than $500.");
  }
  }

  //Constructor
  public CheckingAccount() : base()
  {
    Console.WriteLine("Checking Account constructor");
  }

  //Constructor with parameters
  public CheckingAccount(string accountnumber, string name, double balance) : base (accountnumber, name, balance)
  {
    Console.WriteLine("Checking Account constructor");

  }

 //Methods
 
  public void CalculateInterest(){
    Balance = Balance + (Balance * .0075); 
    Console.WriteLine ("Added interest and updated Balance.");
  }

  public override void Withdrawl(double amount)
  {
  if (Balance >= 500.00)
    base.Withdrawl(amount);
  else
      Console.WriteLine ("Insufficient balance.");

}


}