using System;

public class VisualizationActivity : Activity
{
    public VisualizationActivity()
        : base("Visualization Activity", "This activity will guide you through a visualization of a peaceful scenario to relax and calm your mind.")
    {
    }

    public override void Execute()
    {
        Start();
        int duration = GetDuration();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        Console.WriteLine("Close your eyes and imagine a peaceful scenario, like sitting on a beach or walking through a forest.");
        Pause(3);
        Console.WriteLine("Focus on the sounds, the smells, and the feelings of being in that place.");
        Pause(3);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Imagine the details more clearly...");
            Pause(5);
        }

        End();
    }
}
