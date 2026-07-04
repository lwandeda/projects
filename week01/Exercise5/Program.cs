using System;

class Program
{
    static void Main(string[] args)
    {
        // Call the welcome function
        DisplayWelcome();

        // Get the user's name
        string name = PromptUserName();

        // Get the user's favorite number
        int number = PromptUserNumber();

        // Square the number
        int squaredNumber = SquareNumber(number);

        // Display the result
        DisplayResult(name, squaredNumber);
    }

    // Displays a welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    // Prompts the user for their name and returns it
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    // Prompts the user for their favorite number and returns it
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    // Squares the number and returns the result
    static int SquareNumber(int number)
    {
        return number * number;
    }

    // Displays the final result
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
    }
}