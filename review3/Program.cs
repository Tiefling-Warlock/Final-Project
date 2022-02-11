public class Hand
{
    public static decimal AmountYouCanBet;
    public decimal Card;
    private decimal card = 0;
    
    public bool Fold (decimal deltCard)
    {
        if (card < deltCard)
        {
            return false;
        }
        card = card - deltCard;
        return true;
    }

    public void PayAnte (decimal deltCard)
    {
        card = card + deltCard;
    }

    public decimal GetAnte ()
    {
        return card;
    }
}

class Game
{
    public static void Main()
    {
        Hand RobsHand;
        RobsHand = new Hand();
        RobsHand.Card = 13;

        Hand BobsHand;
        BobsHand = new Hand();
        if (BobsHand.Fold(5))
        {
            Console.WriteLine("You're the last to fold");
        }
        else
        {
            Console.WriteLine("You're the first to fold");
        }

        Hand test = new Hand();
        test.PayAnte(50);
        if(test.GetAnte() != 50)
        {
            Console.WriteLine("You got nothing");
        }
        else
        {
            Console.WriteLine("You got the ante");
        }

        Hand DobsHand = new Hand();
        DobsHand.Card = 10;
        Hand.AmountYouCanBet = 40;
    }
}