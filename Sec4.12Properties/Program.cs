using System;

class Bank
{
    public static void Main()
    {
        StaffMember s = new StaffMember();
        s.SetAge(21);
        Console.WriteLine("Age is: " + s.GetAge());        
    }
}

public class StaffMember
{
    private int age;
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
}