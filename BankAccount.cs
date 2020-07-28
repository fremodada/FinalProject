using System;
  
  class BankAccount
  {
   //Define fields
   private string accountnumber;
   protected double balance;
   protected DateTime datecreated;
   
  //Auto-implemented properties
  public string AccountNumber { 
    get{ return accountnumber;}
    set{
      if (value.Length==6)
        accountnumber = value;
      else
      Console.WriteLine("Account Number must be 6 characters long.");
      }
    }

  public string Name { get; set; }
  public virtual double Balance { 
    get{ return balance; } 
    set{
    if (value >= 0.00)
      balance = value;
    else
    Console.WriteLine ("The Balance cannot be negative.");
    }
    }

  public DateTime DateCreated {
    get { return datecreated; } 
    set {
      if (value <= DateTime.Now)
        datecreated = value;
      else
        Console.WriteLine ("Date Created cannot be in the future.");
    } 
    
    }
  
  //Constructor
  public BankAccount() 
  {
    Name = "";
    AccountNumber = "      ";
    Balance = 0.00;
    DateCreated = DateTime.Now;
  }
  //Constructor with parameters
  public BankAccount(string accountnumber, string name, double balance) 
  {
    AccountNumber = accountnumber;
    Name = name;
    Balance = balance;
    DateCreated = DateTime.Now;
  }

  // Methods

  public void DisplayAccountInfo()
  {
    Console.WriteLine("Account Holder Name: " + Name);
    Console.WriteLine("Account Number: " + AccountNumber);
    Console.WriteLine("Balance: $ " + Balance);
  }

  public void Deposit(double amount){
    Balance = Balance + amount;
    Console.WriteLine("$" + amount + " has been added to the account.");
  }

  public virtual void Withdrawl(double amount)
  {
    if (Balance > amount)
      Balance = Balance - amount;
    else
        Console.WriteLine ("The amount entered exceeds the available Balance.");
    Console.WriteLine("The Balance is: $" + Balance);
  }

  public void CalculateInterest()
  {
    Console.WriteLine("This method will calculate Interest.");
  }

    }