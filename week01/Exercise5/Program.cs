using System;
using System.Globalization;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string userNumber = Console.ReadLine();
        int number = int.Parse(userNumber);
        return number;
    }

    static int SquareNumber(int num)
    {
        return num * num;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");        
    }

    static void Main(string[] args)
    {
        // Displays the message, "Welcome to the Program!"
        DisplayWelcome();

        // Asks for and returns the user's name (as a string)
        string userName = PromptUserName();

        // Asks for and returns the user's favorite number (as an integer)
        int userNumber = PromptUserNumber();

        // Accepts an integer as a parameter and returns that number squared (as an integer)
        int squaredNumber = SquareNumber(userNumber);

        // Accepts the user's name and the squared number and displays them
        DisplayResult(userName, squaredNumber);
    }
}