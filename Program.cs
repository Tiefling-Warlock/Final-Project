using System;

public class Account
{
    // Private Member Data
    private string name;
    private string address;
    private decimal balance;

    public Account()
    {
        Console.WriteLine("We just made an account");
    }

    // Constructor
    public Account(string inName, string inAddress, decimal inBalance)
    {
        string errorMessage = "";
       // if(SetBalance(inBalance)==false)
        {
            errorMessage = errorMessage + "Bad Balance: " + inBalance;
        }
        //if(SetName(inName)==false)
        {
            errorMessage = errorMessage + "Bad name: " + inName;
        }
        //if(SetAddress(inAdress)==false)
        {
            errorMessage = errorMessage + "Bad address: " + inAddress;
        }
        if(errorMessage != "")
        {
            throw new Exception("Account construction failed " + errorMessage);
        }
    }

    public Account (string inName, string inAddress)
    {
        //if(SetName (inName) == false)
        {
            throw new Exception ("Bad Name " + inName);
        }
        //if(SetAddress (inAddress) == false)
        {
            throw new Exception ("Bad Address " + inAddress);
        }
    }
}

class Bank
{
    public static void Main()
    {
        const int MAX_CUST = 100;
        Account[] Accounts = new Account[MAX_CUST];
        Accounts[0] = new Account("Rob", "Robs House", 1000000);
        Accounts[1] = new Account("Jim", "Jims House");
        //Accounts[2] = new Account("Fred");
    }
}