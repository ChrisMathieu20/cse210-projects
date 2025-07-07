using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        string grade = Console.ReadLine();

        int gradePerc = int.Parse(grade);

        string letter = "";
        string digits = "";

        if (gradePerc >= 90)
        {
            letter = "A";
        }
        else if (gradePerc >= 80)
        {
            letter = "B";
        }
        else if (gradePerc >= 70)
        {
            letter = "C";
        }
        else if (gradePerc >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        int lastDigits = (gradePerc % 10);

        if (lastDigits>=7 && letter != "A" || lastDigits>=7 && letter != "F")
        {
            digits = "+";
        }
        else if (lastDigits<3 && letter != "F")
        {
            digits = "-";
        }

        Console.WriteLine($"Your Grade: {letter}{digits}");

        if (gradePerc >= 70)
        {
            Console.WriteLine("Congratulation! You pass!");
        }
        else
        {
            Console.WriteLine("Sorry! You can do your best next time.");
        }
    }
}