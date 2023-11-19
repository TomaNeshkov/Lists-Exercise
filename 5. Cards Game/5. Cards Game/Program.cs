using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> firstPlayerCards = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        List<int> secondPlayerCards = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        while (firstPlayerCards.Count > 0 && secondPlayerCards.Count > 0)
        {
            int firstPlayerCard = firstPlayerCards[0];
            int secondPlayerCard = secondPlayerCards[0];

            if (firstPlayerCard > secondPlayerCard)
            {
                firstPlayerCards.RemoveAt(0);
                secondPlayerCards.RemoveAt(0);

                firstPlayerCards.Add(firstPlayerCard);
                firstPlayerCards.Add(secondPlayerCard);
            }
            else if (firstPlayerCard < secondPlayerCard)
            {
                firstPlayerCards.RemoveAt(0);
                secondPlayerCards.RemoveAt(0);

                secondPlayerCards.Add(secondPlayerCard);
                secondPlayerCards.Add(firstPlayerCard);
            }
            else
            {
                firstPlayerCards.RemoveAt(0);
                secondPlayerCards.RemoveAt(0);
            }
        }

        if (firstPlayerCards.Count > secondPlayerCards.Count)
        {
            Console.WriteLine($"First player wins! Sum: {firstPlayerCards.Sum()}");
        }
        else if (firstPlayerCards.Count < secondPlayerCards.Count)
        {
            Console.WriteLine($"Second player wins! Sum: {secondPlayerCards.Sum()}");
        }
        else
        {
            Console.WriteLine("Draw");
        }
    }
}
