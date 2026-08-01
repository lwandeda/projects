using System;

class Program
{
    static void Main(string[] args)
    {
        // ---------------------------------------------------------
        // Creativity:
        // Added a fourth activity called Gratitude Activity.
        // This activity allows users to record blessings and things
        // they are grateful for, exceeding the core requirements.
        // ---------------------------------------------------------

        // Variable to store the user's menu choice
        string choice = "";

        // Keep showing the menu until the user chooses to quit
        while (choice != "5")
        {
            Console.Clear();

            // Display the main menu
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("-------------------------");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflection Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Start Gratitude Activity");
            Console.WriteLine("5. Quit");
            Console.WriteLine();

            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            Console.Clear();

            // Run the activity the user selected
            switch (choice)
            {
                case "1":
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.Run();
                    break;

                case "2":
                    ReflectionActivity reflection = new ReflectionActivity();
                    reflection.Run();
                    break;

                case "3":
                    ListingActivity listing = new ListingActivity();
                    listing.Run();
                    break;

                case "4":
                    GratitudeActivity gratitude = new GratitudeActivity();
                    gratitude.Run();
                    break;

                case "5":
                    Console.WriteLine("Thank you for using the Mindfulness Program!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            // Pause before showing the menu again
            if (choice != "5")
            {
                Console.WriteLine();
                Console.WriteLine("Press Enter to return to the menu...");
                Console.ReadLine();
            }
        }
    }
}