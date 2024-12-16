using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you feel when it was complete?",
        "What did you learn about yourself through this experience?"
    };

    public ReflectionActivity()
        : base("Reflection Activity", "This activity will help you reflect on times when you have shown strength and resilience.")
    {
    }

    public override void Execute()
    {
        Start();
        int duration = GetDuration();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        Random random = new Random();
        Console.WriteLine(UsePrompt());
        Pause(3);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine(UseQuestion());
            Pause(3);
        }

        End();
    }

    private string UsePrompt()
    {
        if (_prompts.Count == 0)
            _prompts = new List<string>
            {
                "Think of a time when you stood up for someone else.",
                "Think of a time when you did something really difficult.",
                "Think of a time when you helped someone in need.",
                "Think of a time when you did something truly selfless."
            };

        int randomIndex = new Random().Next(_prompts.Count);
        string prompt = _prompts[randomIndex];
        _prompts.RemoveAt(randomIndex);
        return prompt;
    }

    private string UseQuestion()
    {
        if (_questions.Count == 0)
            _questions = new List<string>
            {
                "Why was this experience meaningful to you?",
                "Have you ever done anything like this before?",
                "How did you feel when it was complete?",
                "What did you learn about yourself through this experience?"
            };

        int randomIndex = new Random().Next(_questions.Count);
        string question = _questions[randomIndex];
        _questions.RemoveAt(randomIndex);
        return question;
    }
}
