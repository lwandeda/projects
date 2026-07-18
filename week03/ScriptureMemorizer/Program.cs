// Creativity:
// This program exceeds the core requirements by storing multiple scriptures
// in a library and selecting one at random each time the program runs.

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a library of scriptures
        List<Scripture> scriptures = new List<Scripture>()
        {
            new Scripture(
                new Reference("John", 3, 16),
                "For God so loved the world that he gave his only begotten Son"
            ),

            new Scripture(
                new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all thine heart and lean not unto thine own understanding"
            ),

            new Scripture(
                new Reference("Mosiah", 2, 17),
                "When ye are in the service of your fellow beings ye are only in the service of your God"
            ),

            new Scripture(
                new Reference("Alma", 37, 6),
                "By small and simple things are great things brought to pass"
            )
        };

        // Pick one scripture at random
        Random random = new Random();
        Scripture scripture = scriptures[random.Next(scriptures.Count)];

        // Main program loop
        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine();
            Console.Write("Press Enter to continue or type 'quit': ");

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords();
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine();
        Console.WriteLine("Program finished.");
    }
}