GoalManager manager = new GoalManager();

bool running = true;

while (running)
{
    Console.WriteLine();
    Console.WriteLine("Eternal Quest");
    Console.WriteLine();
    
    manager.DisplayScore();

    Console.WriteLine();
    Console.WriteLine("Menu Options:");
    Console.WriteLine("  1. Create New Goal");
    Console.WriteLine("  2. List Goals");
    Console.WriteLine("  3. Save Goals");
    Console.WriteLine("  4. Load Goals");
    Console.WriteLine("  5. Record Event");
    Console.WriteLine("  6. Quit");

    Console.Write("Select a choice from the menu: ");
    string choice = Console.ReadLine();

    Console.WriteLine();

    switch (choice)
    {
        case "1":
            Console.WriteLine("The types of goals are:");
            Console.WriteLine("  1. Simple Goal");
            Console.WriteLine("  2. Eternal Goal");
            Console.WriteLine("  3. Checklist Goal");

            Console.Write("Which type of goal would you like to create? ");
            string goalType = Console.ReadLine();

            if (goalType == "1")
            {
                manager.CreateSimpleGoal();
            }
            else if (goalType == "2")
            {
                manager.CreateEternalGoal();
            }
            else if (goalType == "3")
            {
                manager.CreateChecklistGoal();
            }
            else
            {
                Console.WriteLine("Invalid goal type.");
            }

            break;

        case "2":
            manager.DisplayGoals();
            break;

        case "3":
            Console.WriteLine("Save functionality coming next.");
            break;

        case "4":
            Console.WriteLine("Load functionality coming next.");
            break;

        case "5":
            manager.RecordEvent();
            break;

        case "6":
            running = false;
            Console.WriteLine("Goodbye!");
            break;

        default:
            Console.WriteLine("Invalid choice. Please choose 1-6.");
            break;
    }
}