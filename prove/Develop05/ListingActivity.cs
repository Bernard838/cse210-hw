using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "What are some of your personal heroes?"
    };

    public ListingActivity()
        : base("Listing Activity", "This activity will help you reflect on the good things in your life.")
    {
    }

    public override void Execute()
    {
        Start();
        Console.WriteLine(_prompts[new Random().Next(_prompts.Count)]);
        Pause(3);

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        List<string> responses = new List<string>();

        while (DateTime.Now < endTime)
        {
            Console.Write("Enter an item: ");
            responses.Add(Console.ReadLine());
        }

        Console.WriteLine($"You listed {responses.Count} items!");
        Console.WriteLine("Here are the items you listed:");
        foreach (var item in responses)
        {
            Console.WriteLine($"- {item}");
        }

        End();
    }
}
