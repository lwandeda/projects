
// W02 Journal Program

// Creativity:
// I exceeded the assignment requirements by adding a Mood
// field. Every journal entry stores the user's mood and
// saves it to the f
using System;

class Program
{
    static void Main(string[] args)
   {
        // Create a Journal object.
        Journal journal = new Journal();

        // Create a PromptGenerator object.
        PromptGenerator promptGenerator = new PromptGenerator();

        // Variable used to control the menu loop.
        bool running = true;

        // Keep showing the menu until the user chooses Quit.
        while (running)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Journal Menu");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("\nChoose an option (1-5): ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                
                // Write a new journal entry
                
                case "1":

                    // Create a new journal entry.
                    Entry entry = new Entry();

                    // Automatically store today's date.
                    entry._date = DateTime.Now.ToShortDateString();

                    // Get a random prompt.
                    entry._promptText = promptGenerator.GetRandomPrompt();

                    Console.WriteLine();
                    Console.WriteLine($"Prompt: {entry._promptText}");

                    Console.Write("Your response: ");
                    entry._entryText = Console.ReadLine();

                    // Extra creativity requirement.
                    Console.Write("How are you feeling today? ");
                    entry._mood = Console.ReadLine();

                    // Add the completed entry to the journal.
                    journal.AddEntry(entry);

                    Console.WriteLine("\nJournal entry added successfully!\n");
                    break;

                // Display all entries
                
                case "2":

                    Console.WriteLine();
                    journal.DisplayAll();
                    break;

                
                // Save journal
                
                case "3":

                    Console.Write("\nEnter filename: ");
                    string saveFile = Console.ReadLine();

                    journal.SaveToFile(saveFile);

                    break;

                
                // Load journal
                
                case "4":

                    Console.Write("\nEnter filename: ");
                    string loadFile = Console.ReadLine();

                    journal.LoadFromFile(loadFile);

                    break;

            
                // Quit
                
                case "5":

                    running = false;

                    Console.WriteLine("\nThank you for using the Journal Program.");
                    Console.WriteLine("Goodbye!");

                    break;

                
                // Invalid menu option
                
                default:

                    Console.WriteLine("\nInvalid option. Please choose a number between 1 and 5.\n");
                    break;
            }
        }
    }
}