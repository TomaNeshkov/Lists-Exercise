using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        List<int> bombData = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        int bombNumber = bombData[0];
        int power = bombData[1];

        DetonateBombNumbers(numbers, bombNumber, power);

        int sum = numbers.Sum();
        Console.WriteLine(sum);
    }

    static void DetonateBombNumbers(List<int> numbers, int bombNumber, int power)
    {
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] == bombNumber)
            {
                int leftBoundary = Math.Max(0, i - power);
                int rightBoundary = Math.Min(numbers.Count - 1, i + power);

                int elementsToRemove = rightBoundary - leftBoundary + 1;
                numbers.RemoveRange(leftBoundary, elementsToRemove);

                i = Math.Max(-1, i - power - 1);
            }
        }
    }
}
