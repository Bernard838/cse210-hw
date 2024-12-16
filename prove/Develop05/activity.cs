using System;
using System.Threading;

public abstract class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void Start()
    {
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine(_description);
        Console.Write("Enter the duration of the activity in seconds: ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        Pause(3);
    }

    public void End()
    {
        Console.WriteLine("Good job! You have completed the activity.");
        Console.WriteLine($"You completed the {_name} for {_duration} seconds.");
        Pause(3);
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void Pause(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("...");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public void CountdownAnimation(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine($"Time remaining: {i} seconds");
            Thread.Sleep(1000);
        }
    }

    public abstract void Execute();
}
