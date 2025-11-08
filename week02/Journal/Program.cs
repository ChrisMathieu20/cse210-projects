using System;
using System.Collections.Generic;
using System.IO;

class Program
{   
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        PromptGenerator prompt = new PromptGenerator();

        // Welcome
        Console.WriteLine("Welcome to the Journal Program!");

        // Until the user didn't quit, the program shows the menu
        bool isQuit = false;
        while (!isQuit)
        {
            Console.WriteLine("Please select one of the following choices:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            Console.Write("What would you like to do? ");
            string answer = Console.ReadLine();
            int choice = int.Parse(answer);

            // The choice value between 1 and 5
            if (choice <= 5 && choice > 0)
            {
                if (choice != 5)
                {
                    isQuit = false;
                    // Select to 'write'
                    if (choice == 1)
                    {
                        // Generate a random prompt
                        string randomPrompt = prompt.GetRandomPrompt();
                        Console.WriteLine(randomPrompt);

                        // Get the user entry
                        Console.Write("> ");
                        string userEntry = Console.ReadLine();

                        // Get date now
                        DateTime theCurrentTime = DateTime.Now;
                        string dateText = theCurrentTime.ToShortDateString();

                        // Assign the entry to a variable
                        Entry anEntry = new Entry();
                        anEntry._entryText = userEntry;
                        anEntry._promptText = randomPrompt;
                        anEntry._date = dateText;

                        // Add the entry to the list
                        theJournal.AddEntry(anEntry);
                    }
                    // Select to 'display'
                    else if (choice == 2)
                    {
                        theJournal.DisplayAll();
                    }
                    // Select to 'load'
                    else if (choice == 3)
                    {
                        Console.Write("What is the file? ");
                        string fileName = Console.ReadLine();
                        theJournal.LoadFromFile(fileName);
                    }
                    // Select to 'save'
                    else if (choice == 4)
                    {
                        Console.Write("What is the file? ");
                        string fileName = Console.ReadLine();
                        theJournal.SaveToFile(fileName);
                        Console.WriteLine("Saved!");
                    }

                    // Separator
                    Console.WriteLine("//////////////////////////////");
                }
                // When quit
                else
                {
                    Console.WriteLine("Have a nice day!");
                    isQuit = true;
                }
            }
            // If the value entered is lower than 1 or upper than 5
            else
            {
                Console.WriteLine("Out of range");
                Console.WriteLine("//////////////////////////////");
                isQuit = false;
            }
        }
    }
}