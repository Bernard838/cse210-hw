using System;
using System.Collections.Generic;

// The Entry class represents a single journal entry.
public class Entry
{
    public string Date { get; set; } // Storing the date of the entry.
    public string Prompt { get; set; } // Storing the journal prompt.
    public string Response { get; set; } // Storing the user's response to the prompt.
    public List<string> Tags { get; set; } = new List<string>(); // Storing optional tags for better organization.

    // Showing the entry, including tags if present.
    public void Display()
    {
        Console.WriteLine($"{Date}: {Prompt}\nResponse: {Response}");
        if (Tags.Count > 0)
        {
            Console.WriteLine($"Tags: {string.Join(", ", Tags)}");
        }
        Console.WriteLine();
    }
}