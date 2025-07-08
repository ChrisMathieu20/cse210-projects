using System;

class Program
{
    static void Main(string[] args)
    {
        bool continu = true;

        while (continu == true)
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1,10);

            int guess = 0;
            int count = 0;

            while (guess != number)
            {
                Console.Write("What is your guess? ");
                string userGuess = Console.ReadLine();
                guess = int.Parse(userGuess);

                if (guess < number)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > number)
                {
                    Console.WriteLine("Lower");
                }
                count++;
            }
            Console.WriteLine("You guessed it!");
            Console.WriteLine($"Guesses: {count}");

            Console.Write("Do you want to play again? yes or no -- ");
            string question = Console.ReadLine();
            
            if (question == "yes")
            {
                continu = true;
            }
            else
            {
                continu = false;
            }
        }
    }
}