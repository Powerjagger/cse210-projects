using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<int, int> numberCounts = new Dictionary<int, int>();
        List<int> numbers = new List<int>();
        int sum = 0;
        int highest = int.MinValue;
        int lowest = int.MaxValue;

        Console.WriteLine("Enter numbers (enter 0 to stop):");

        while (true)
        {
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                if (number == 0)
                    break;

                // Update number counts
                if (numberCounts.ContainsKey(number))
                {
                    numberCounts[number]++;
                }
                else
                {
                    numberCounts[number] = 1;
                }

                sum += number;

                if (number > highest)
                {
                    highest = number;
                }

                if (number < lowest)
                {
                    lowest = number;
                }

                numbers.Add(number);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number or 0 to stop.");
            }
        }

        double average = numbers.Count > 0 ? (double)sum / numbers.Count : 0;
        average = Math.Round(average, 2);

        Console.WriteLine("Number Counts:");
        foreach (var kvp in numberCounts)
        {
            Console.WriteLine($"Number {kvp.Key}: Count {kvp.Value}");
        }

        Console.WriteLine($"Sum of all numbers: {sum}");
        Console.WriteLine($"Average number: {average}");
        Console.WriteLine($"Highest number: {highest}");
        Console.WriteLine($"Lowest number: {lowest}");
    }
}
