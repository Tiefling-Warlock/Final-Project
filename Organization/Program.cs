using System;
using System.IO;
using CustomerBanking;

class AccountTest
{
    public static void Main()
    {
        CustomerBanking.Account test;
        test = new CustomerBanking.Account();
        test.PayInFunds (50);
        Console.WriteLine("Balance: " + test.GetBalance());
    }
}