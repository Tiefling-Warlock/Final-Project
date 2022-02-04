using System;

public interface IAccount
{
    void PayInFunds(decimal amount);
    bool WithdrawFunds(decimal amount);
    decimal GetBalance();
    string GetName();
    
}

public interface IBank
{
    IAccount FindAccount(string name);
    bool StoreAccount(IAccount account);
}

class BankProgram
{
      
    private IAccount [] accounts;
    public ArrayBank(int bankSize)
    {
        accounts = new IAccount[bankSize];
        
    }
    public bool StoreAccount(IAccount account)
    {
        int position = 0;
        for(position = 0; position<accounts.Length; position++)
        {
            if(accounts[position] == null)
            {
                accounts[position] = account;
                return true;
            }
        }
        return false;
    }
    public IAccount FindAccount(string name)
    {
        int position = 0;
        for(position = 0; position<accounts.Length; position++)
        {
            if(accounts[position] == null)
            {
                continue;
            }
            if(accounts[position].GetName() == name)
            {
                return accounts[position];
            }
        }
        return null;
    }

    public static void Main()
    {
        ArrayBank ourBank = new ArrayBank(100);
        Account newAccount = new Account("Rob", "Robs House",
        1000000);
        if(ourBank.StoreAccount(newAccount) == true)
        Console.WriteLine("Account added to bank");
        IAccount storedAccount = ourBank.FindAccount("Rob");
        if(storedAccount!=null)
        Console.WriteLine("Account found in bank");

    }
}

class HashBank : IBank
{
    Hashtable bankHashtable = new Hashtable();
    public IAccount FindAccount(string name)
    {
        return bankHashtable[name] as IAccount;
    }
    public bool StoreAccount(IAccount account)
    {
        bankHashtable.Add(account.GetName(), account);
        return true;
    }
}