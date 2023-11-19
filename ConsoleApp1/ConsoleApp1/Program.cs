using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> wagons = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        int maxCapacity = int.Parse(Console.ReadLine());

        string command;
        while ((command = Console.ReadLine()) != "end")
        {
            string[] commandArgs = command.Split();
            string action = commandArgs[0];

            if (action == "Add")
            {
                int passengers = int.Parse(commandArgs[1]);
                wagons.Add(passengers);
            }
            else
            {
                int passengers = int.Parse(action);

                for (int i = 0; i < wagons.Count; i++)
                {
                    if (wagons[i] + passengers <= maxCapacity)
                    {
                        wagons[i] += passengers;
                        break;
                    }
                }
            }
        }

        Console.WriteLine(string.Join(" ", wagons));
    }
}
