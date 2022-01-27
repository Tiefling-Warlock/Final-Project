// See https://aka.ms/new-console-template for more information
using System;
class Account
{
    private string name;
    private decimal balance;

    public override string ToString()
    {
        return "Name: " + name + " balance: " + balance;
    }

    public Account (string inName, decimal inBalance)
    {
        name = inName;
        balance = inBalance;
    }
}

class Point
{
    public int x;
    public int y;

    public override bool Equals(object obj)
    {
        Point p = (Point) obj;
        if((p.x == x) && (p.y == y))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}



class Bank
{
    public static void Main()
    {
        Account a = new Account("Rob", 25);
        Console.WriteLine(a);

        Point spaceshipPosition = new Point();
        spaceshipPosition.x = 1;
        spaceshipPosition.y = 2;

        Point missilePosition = new Point();
        missilePosition.x = 1;
        missilePosition.y = 2;

        if (spaceshipPosition == missilePosition)
        {
            Console.WriteLine("Bang");
        }

        if (missilePosition.Equals(spaceshipPosition))
        {
            Console.WriteLine("Bang");
        }
    }
}