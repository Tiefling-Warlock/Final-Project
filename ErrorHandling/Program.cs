using System;

public class BankException : System.Exception
{
    public BankException(string message) :
    base(message)
    {
    }
}
public class BankExceptionBadName : System.Exception
{
    public BankExceptionBadName(string message) :
    base(message)
    {
    }
}
public class BankExceptionBadAddress : System.Exception
{
    public BankExceptionBadAddress(string message) :
    base(message)
    {
    }

    class Bank
    {
        public static void Main()
        {
            Account a;
            try
            {
                a = new Account("Rob", "");
            }
            catch (BankExceptionBadName nameException)
            {
                Console.WriteLine("Invalid name : " +
                nameException.Message);
            }
            catch (BankExceptionBadAddress addrException)
            {
                Console.WriteLine("Invalid address : " +
                addrException.Message);
            }
            catch (System.Exception exception)
            {
                Console.WriteLine("System exception : " +
                exception.Message);
            }

        }
    }
}