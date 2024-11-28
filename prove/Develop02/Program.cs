
using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        // Addeding password in protection for privacy.
        Console.Write("Set a password for your journal: ");
        string password = Console.ReadLine();
        journal.SetPassword(password);

        Console.Write("Enter password to access the journal: ");
        if (!journal.Authenticate(Console.ReadLine()))
        {
            Console.WriteLine("Incorrect password. Exiting program.");
            return;
        }

        string[] prompts = new string[]
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file (JSON format)");
            Console.WriteLine("4. Load the journal from a file (JSON format)");
            Console.WriteLine("5. Search entries by date");
            Console.WriteLine("6. Search entries by tag");
            Console.WriteLine("7. Generate weekly summary");
            Console.WriteLine("8. Quit");

            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string prompt = prompts[new Random().Next(prompts.Length)];
                    Console.WriteLine($"Prompt: {prompt}");
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();

                    Console.Write("Add tags (comma-separated, optional): ");
                    string tagsInput = Console.ReadLine();
                    List<string> tags = string.IsNullOrWhiteSpace(tagsInput)
                        ? null
                        : new List<string>(tagsInput.Split(','));

                    journal.AddEntry(prompt, response, tags);
                    break;

                case "2":
                    journal.DisplayJournal();
                    break;

                case "3":
                    Console.Write("Enter filename to save: ");
                    journal.SaveToJson(Console.ReadLine());
                    break;

                case "4":
                    Console.Write("Enter filename to load: ");
                    journal.LoadFromJson(Console.ReadLine());
                    break;

                case "5":
                    Console.Write("Enter date (MM/DD/YYYY): ");
                    journal.SearchByDate(Console.ReadLine());
                    break;

                case "6":
                    Console.Write("Enter tag to search: ");
                    journal.SearchByTag(Console.ReadLine());
                    break;

                case "7":
                    journal.GenerateWeeklySummary();
                    break;

                case "8":
                    Console.WriteLine("Goodbye!");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }
}