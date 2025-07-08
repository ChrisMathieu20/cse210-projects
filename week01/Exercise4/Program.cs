using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> lists = new List<int>();

        int series = 1;

        while (series != 0)
        {
            if (series > 0)
            {
                Console.Write("Enter a series of number: ");
                string seriesNumber = Console.ReadLine();
                series = int.Parse(seriesNumber);

                lists.Add(series);
            }
        }

        int sum = 0;
        
        foreach (int list in lists)
        {
            int add = list;
            sum = sum + add;
        }
        Console.WriteLine($"The sum is: {sum}");
    }
}