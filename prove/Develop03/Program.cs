using System;

class Program
{

    static void Main(string[] args)
    {
        // Add a scripture's text and reference at the beginning.
        Scripture scripture = new Scripture(
            new Reference("Proverbs", "3:5", "6"),
            "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."
        );

        // The bible Memorization loop
        while (!scripture.IsFullyHidden())
        {
            Console.Clear();
            scripture.Display();
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords();
        }

        // Displaying the Final message
        Console.Clear();
        scripture.Display();
        Console.WriteLine("\nAll words have been hidden. Well done!");
    }
}
