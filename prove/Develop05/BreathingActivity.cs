using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing Activity", "This activity will help you relax by guiding you through slow, deep breathing.")
    {
    }

    public override void Execute()
    {
        Start();
        int duration = GetDuration();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            AnimateBreath("Breathe in...");
            Pause(3);
            AnimateBreath("Breathe out...");
            Pause(3);
        }

        End();
    }

    private void AnimateBreath(string message)
    {
        int length = message.Length;
        for (int i = 1; i <= length; i++)
        {
            Console.Clear();
            Console.WriteLine(message.Substring(0, i));
            Thread.Sleep(200);
        }

        for (int i = length - 1; i >= 1; i--)
        {
            Console.Clear();
            Console.WriteLine(message.Substring(0, i));
            Thread.Sleep(200);
        }
    }
}
