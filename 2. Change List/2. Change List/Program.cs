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
        while ((command = Console.ReadLine()) != "end")
        {
            string[] commandArgs = command.Split();
            string action = commandArgs[0];

            switch (action)
            {
                case "Delete":
                    int elementToDelete = int.Parse(commandArgs[1]);
                    DeleteElement(numbers, elementToDelete);
                    break;

                case "Insert":
                    int elementToInsert = int.Parse(commandArgs[1]);
                    int position = int.Parse(commandArgs[2]);
                    InsertElement(numbers, elementToInsert, position);
                    break;
            }
        }

        Console.WriteLine(string.Join(" ", numbers));
    }

    static void DeleteElement(List<int> numbers, int element)
    {
        numbers.RemoveAll(x => x == element);
    }

    static void InsertElement(List<int> numbers, int element, int position)
    {
        if (position >= 0 && position < numbers.Count)
        {
            numbers.Insert(position, element);
        }
    }
}
