using System;

class Program
{
    static void Main(string[] args)
    {
        // Core Requirement 1.1 - Ask user for their grade percentage
        Console.Write("Enter your grade percentage: ");
        string grade = Console.ReadLine();
        int gradePerc = int.Parse(grade);

        // Core Requirement 1.2 - Match with the appropriate letter
        // Core Requirement 2.1 - At least 70% to pass the class
        // Core Requirement 3.1 - Variable 'letter' set with the appropriate value
        string letter;
        bool isPass;
        if (gradePerc >= 90)
        {
            letter = "A";
            isPass = true;
        }
        else if (gradePerc >= 80)
        {
            letter = "B";
            isPass = true;
        }
        else if (gradePerc >= 70)
        {
            letter = "C";
            isPass = true;
        }
        else if (gradePerc >= 60)
        {
            letter = "D";
            isPass = false;
        }
        else
        {
            letter = "F";
            isPass = false;
        }

        // Stretch Challenge 1 - Determine the sign after the letter according to the digits
        // Stretch Challenge 2 - No A+, just A and A-
        // Stretch Challenge 3 - No F+ and F-, just F
        string gradeSign;
        int gradeMod = gradePerc % 10;
        if ((gradeMod >= 7) && letter != "A" && letter != "F")
        {
            gradeSign = "+";
        }
        else if ((gradeMod < 3) && letter != "F")
        {
            gradeSign = "-";
        }
        else
        {
            gradeSign = "";
        }
        
        // Core Requirement 1.3 & 3.2 - Print the grade letter
        Console.WriteLine($"Grade letter: {letter}{gradeSign}");

        // Core Requirement 2.2 - Determine if the user pass the course or not
        string message;
        if (isPass)
        {
            message = "Congratulation! You pass";
        }
        else
        {
            message = "Oh, sorry! You didn't pass. You can do much better next time.";
        }

        // Core Requirement 2.3 - Display the message
        Console.WriteLine(message);
    }
}