using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

// Additional features are implemented and the collection of entries is managed by the Journal class.
public class Journal
{
    private List<Entry> _entries = new List<Entry>(); // Storing the list of journal entries.
    private string _password; // Storing the password for authentication.

    // Setting the password for the journal.
    public void SetPassword(string password)
    {
        _password = password;
    }

    // using the password that was entered to authenticate the user.
    public bool Authenticate(string inputPassword)
    {
        return _password == inputPassword;
    }

    // Adding a new entry to the journal.
    public void AddEntry(string prompt, string response, List<string> tags = null)
    {
        var entry = new Entry
        {
            Date = DateTime.Now.ToShortDateString(),
            Prompt = prompt,
            Response = response,
            Tags = tags ?? new List<string>()
        };
        _entries.Add(entry);
    }

    // Displaying all entries in the journal.
    public void DisplayJournal()
    {
        Console.WriteLine("Journal Entries:");
        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }

    // keeps the journal entries in a JSON file so that they are more suitable with other programs.
    public void SaveToJson(string fileName)
    {
        string json = JsonSerializer.Serialize(_entries);
        File.WriteAllText(fileName, json);
    }

    // Loading journal entries from a JSON file.
    public void LoadFromJson(string fileName)
    {
        if (File.Exists(fileName))
        {
            string json = File.ReadAllText(fileName);
            _entries = JsonSerializer.Deserialize<List<Entry>>(json) ?? new List<Entry>();
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }

    // Searching for entries by a specific date.
    public void SearchByDate(string date)
    {
        var foundEntries = _entries.FindAll(entry => entry.Date == date);
        if (foundEntries.Count > 0)
        {
            Console.WriteLine($"Entries for {date}:");
            foreach (var entry in foundEntries)
            {
                entry.Display();
            }
        }
        else
        {
            Console.WriteLine($"No entries found for {date}.");
        }
    }

    // Searching for entries by a specific tag.
    public void SearchByTag(string tag)
    {
        var taggedEntries = _entries.FindAll(entry => entry.Tags.Contains(tag));
        if (taggedEntries.Count > 0)
        {
            Console.WriteLine($"Entries with tag '{tag}':");
            foreach (var entry in taggedEntries)
            {
                entry.Display();
            }
        }
        else
        {
            Console.WriteLine($"No entries found with tag '{tag}'.");
        }
    }

    // Generating a summary of entries from the last 7 days.
    public void GenerateWeeklySummary()
    {
        var last7Days = _entries.FindAll(entry =>
            DateTime.Parse(entry.Date) >= DateTime.Now.AddDays(-7));

        Console.WriteLine("Weekly Summary:");
        foreach (var entry in last7Days)
        {
            Console.WriteLine($"- {entry.Date}: {entry.Response}");
        }
    }
}