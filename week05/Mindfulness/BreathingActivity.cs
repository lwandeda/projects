using System;

public class BreathingActivity : Activity
{
    // Constructor
    public BreathingActivity()
        : base(
            "Breathing Activity",
            "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing."
        )
    {
    }

    // Run the breathing activity
    public void Run()
    {
        DisplayStartingMessage();

        int elapsedTime = 0;

        while (elapsedTime < GetDuration())
        {
            Console.WriteLine();
            Console.Write("Breathe in... ");
            ShowCountDown(5);

            elapsedTime += 5;

            if (elapsedTime >= GetDuration())
            {
                break;
            }

            Console.WriteLine();
            Console.Write("Breathe out... ");
            ShowCountDown(5);

            elapsedTime += 5;
        }

        DisplayEndingMessage();
    }
}