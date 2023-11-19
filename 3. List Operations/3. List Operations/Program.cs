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

        string command;
        while ((command = Console.ReadLine()) != "End")
        {
            string[] commandArgs = command.Split();
            string action = commandArgs[0];

            switch (action)
            {
                case "Add":
                    int numberToAdd = int.Parse(commandArgs[1]);
                    AddNumber(numbers, numberToAdd);
                    break;

                case "Insert":
                    int numberToInsert = int.Parse(commandArgs[1]);
                    int indexToInsert = int.Parse(commandArgs[2]);
                    InsertNumber(numbers, numberToInsert, indexToInsert);
                    break;

                case "Remove":
                    int indexToRemove = int.Parse(commandArgs[1]);
                    RemoveNumber(numbers, indexToRemove);
                    break;

                case "Shift":
                    string direction = commandArgs[1];
                    int count = int.Parse(commandArgs[2]);
                    ShiftNumbers(numbers, direction, count);
                    break;
            }
        }

        Console.WriteLine(string.Join(" ", numbers));
    }

    static void AddNumber(List<int> numbers, int number)
    {
        numbers.Add(number);
    }

    static void InsertNumber(List<int> numbers, int number, int index)
    {
        if (index >= 0 && index <= numbers.Count)
        {
            numbers.Insert(index, number);
        }
        else
        {
            Console.WriteLine("Invalid index");
        }
    }

    static void RemoveNumber(List<int> numbers, int index)
    {
        if (index >= 0 && index < numbers.Count)
        {
            numbers.RemoveAt(index);
        }
        else
        {
            Console.WriteLine("Invalid index");
        }
    }

    static void ShiftNumbers(List<int> numbers, string direction, int count)
    {
        count = count % numbers.Count;

        if (direction == "left")
        {
            for (int i = 0; i < count; i++)
            {
                int firstNumber = numbers[0];
                numbers.RemoveAt(0);
                numbers.Add(firstNumber);
            }
        }
        else if (direction == "right")
        {
            for (int i = 0; i < count; i++)
            {
                int lastNumber = numbers[numbers.Count - 1];
                numbers.RemoveAt(numbers.Count - 1);
                numbers.Insert(0, lastNumber);
            }
        }
    }
}
