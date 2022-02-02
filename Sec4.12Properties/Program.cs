using System;

class Bank
{
    public static void Main()
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
}