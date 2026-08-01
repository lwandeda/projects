using System;
using System.Collections.Generic;

public class GratitudeActivity : Activity
{
    // Private member variable
    private List<string> _gratitudeItems;

    // Constructor
    public GratitudeActivity()
        : base(
            "Gratitude Activity",
            "This activity will help you focus on the blessings in your life by writing down things you are grateful for."
        )
    {
        _gratitudeItems = new List<string>();
    }

    // Run the activity
    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine();
        Console.WriteLine("Take a moment to think about the blessings in your life.");
        Console.WriteLine("You may begin in...");
        ShowCountDown(5);

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("Write something you are grateful for: ");

            string response = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(response))
            {
                _gratitudeItems.Add(response);
            }
        }

        Console.WriteLine();
        Console.WriteLine($"You wrote {_gratitudeItems.Count} blessings.");

        DisplayEndingMessage();
    }
}