using System;
using System.Linq;

class Print_a_Deck_of_52_Cards
{

    public enum Suit
    {
        Club = '\u2663',
        Diamond = '\u2666',
        Heart = '\u2665',
        Spades = '\u2660',
    }

    public enum CardNumber
    {

        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        J = 11,
        Q = 12,
        K = 13,
        A = 14
    }

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;

        foreach (CardNumber val in Enum.GetValues(typeof(CardNumber)))
        {
            foreach (Suit val1 in Enum.GetValues(typeof(Suit)))
            {
                if ((int)val > 10)
                {
                    Console.Write("{0}{1} ", val, (char) val1);
                }
                else
                {
                    Console.Write("{0}{1} ", (int)val, (char)val1);
                }
            }

            Console.WriteLine();
        }

    }
}

