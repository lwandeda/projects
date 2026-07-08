using System.Collections.Generic;

// This class represents a person's resume.

public class Resume
{
    // Store the person's name.
    public string _name = "";

    // Store a list of jobs.
    // We create an empty list immediately.
    public List<Job> _jobs = new List<Job>();

    // Display the whole resume.
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        // Go through every job in the list.
        foreach (Job job in _jobs)
        {
            // Display each job.
            job.Display();
        }
    }
}