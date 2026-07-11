// The Entry class represents ONE journal entry.
// It stores the date, the prompt, the user's response,
// and (for extra credit) the user's mood.

using System;

 class Entry
{
    
    // Member Variables (Data)
    // Stores the date the journal entry was created.
    public string _date;

    // Stores the question (prompt) shown to the user.
    public string _promptText;

    // Stores the user's journal response.
    public string _entryText;

    // EXTRA REQUIREMENT:
    // Stores the user's mood for the day.
    public string _mood;

    // Methods (Behaviors)
    
    // This method displays one journal entry on the screen.
    public void Display()
    {
        Console.WriteLine("--------------------------------------");
        Console.WriteLine($"Date   : {_date}");
        Console.WriteLine($"Prompt : {_promptText}");
        Console.WriteLine($"Answer : {_entryText}");
        Console.WriteLine($"Mood   : {_mood}");
        Console.WriteLine("--------------------------------------");
        Console.WriteLine();
    }
}