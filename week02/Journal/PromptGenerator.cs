// The PromptGenerator class is responsible for
// storing journal prompts and returning one at random.

using System;
using System.Collections.Generic;

public class PromptGenerator
{
    // Member Variables
   
    // A list that stores all the journal prompts.
    private List<string> _prompts = new List<string>();

    // Random object used to select a random prompt.
    private Random _random = new Random();
    // Constructor
    // The constructor runs automatically when a new
    // PromptGenerator object is created.
    public PromptGenerator()
    {
        // Add at least 10 prompts to the list.

        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");
        _prompts.Add("What made me smile today?");
        _prompts.Add("What challenge did I overcome today?");
        _prompts.Add("What am I most grateful for today?");
        _prompts.Add("What did I learn today?");
        _prompts.Add("How did I help someone today?");
    }
    // Methods
    // Returns one random prompt from the list.
    public string GetRandomPrompt()
    {
        // Generate a random index between 0 and the
        // number of prompts minus one.
        int index = _random.Next(_prompts.Count);

        // Return the prompt at that index.
        return _prompts[index];
    }
}