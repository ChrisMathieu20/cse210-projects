using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> series = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished");

        bool isFinished = false;
        while (!isFinished)
        {
            // Ask user for series of numbers
            Console.Write("Enter number: ");
            string userEntry = Console.ReadLine();
            int number = int.Parse(userEntry);

            if (number != 0)
            {
                series.Add(number);
                isFinished = false;
            }
            else
            {
                isFinished = true;
            }
        }

        // Core Requirement 1 - Compute the total of the numbers in the list
        int sum = 0;
        foreach (int serie in series)
        {
            sum += serie;
        }
        Console.WriteLine($"The sum is: {sum}");

        // Core Requirement 2 - Compute the average of the numbers in the list
        float average = ((float)sum) / series.Count;
        Console.WriteLine($"The average is: {average}");

        // Core Requirement 3 - The largest number in the list
        int largest = series[0];
        foreach (int number in series)
        {
            if (number > largest)
            {
                largest = number;
            }
        }
        Console.WriteLine($"The largest number is: {largest}");

        // Stretch Challenge 1 - The smallest positive number
        int smallest = series[0];
        foreach (int number in series)
        {
            if (number > 0)
            {
                if (number < smallest)
                {
                    smallest = number;
                }
            }
        }
        Console.WriteLine($"The smallest positive number is: {smallest}");

        // Stretch Challenge 2 - The sorted list
        series.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int serie in series)
        {
            Console.WriteLine(serie);
        }
    }
}