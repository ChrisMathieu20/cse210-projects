using System;

class Program
{
    static void Main(string[] args)
    {
        // Random number
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        bool isAgain = true;
        while (isAgain)
        {
            bool isGuessed = true;
            int i = 0;
            while (isGuessed)
            {
                // Ask user for a guess
                Console.Write("What is your guess? ");
                string userGuess = Console.ReadLine();
                int guess = int.Parse(userGuess);

                // Determine if the user needs to guess higher or lower or they guessed it
                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                    isGuessed = true;
                    i++;
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                    isGuessed = true;
                    i++;
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    isGuessed = false;
                    i++;
                }
            }

            Console.WriteLine($"You guesses {i} times.");

            Console.Write("Do you want to play again? ");
            string answer = Console.ReadLine().ToLower();

            if (answer == "yes")
            {
                isAgain = true;
            }
            else
            {
                isAgain = false;
            }
        }
    }
}