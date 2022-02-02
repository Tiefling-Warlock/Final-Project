using System;

class Bank
{
    public static void FormerMain()
    {
        StaffMember s = new StaffMember();
        s.SetAge(21);
        Console.WriteLine("Age is: " + s.GetAge());
        StaffMember t = new StaffMember();
        t.Age = 22;
        Console.WriteLine("Age is: " + t.Age);        
    }
}

public class StaffMember
{
    private int age;
    private int ageValue;
    public int GetAge()
    {
        return this.age;
    }
    public void SetAge(int inAge)
    {
        if ((inAge > 0) && (inAge < 120))
        {
            this.age = inAge;
        }
    }
    public int Age
    {
        set
        {
            if((value > 0) && (value < 120))
            {
                this.ageValue = value;
            }
        }
        get
        {
            return this.ageValue;
        }
    }
    public int AgeInMonths
    {
        get
        {
            return this.ageValue*12;
        }
    }
    public bool setAge(int inAge)
    {
        if((inAge > 0) && (inAge < 120))
        {
            this.age = inAge;
            return true;
        }
        return false;
    }
}

interface IStaff
{
    int Age
    {
        get;
        set;
    }
}


public delegate decimal CalculateFee(decimal balance);
public class DelegateDemo
{
    public static decimal RipoffFee(decimal balance)
    {
        Console.WriteLine("Calling the Ripoff Method");
        if (balance < 0)
        {
            return 100;
        }
        else
        {
            return 1;
        }
    }
    public static decimal FriendlyFee(decimal balance)
    {
        Console.WriteLine("Calling the Friendly Method");
        if(balance < 0)
        {
            return 10;
        }
        else
        {
            return 1;
        }
    }
    public static void Main()
    {
        CalculateFee calc;

        calc = new CalculateFee(RipoffFee);
        calc(-1); // this will call the Ripoff method
        calc = new CalculateFee(FriendlyFee);
        calc(-1); //this will call the Friendly method
    }
}