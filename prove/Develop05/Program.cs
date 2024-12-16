using System;

class Program
{
    static void Main(string[] args)
    {
        // Load previous activity log
        ActivityLog.LoadLog();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Visualization Activity");
            Console.WriteLine("5. Quit");
            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            Activity activity = choice switch
            {
                "1" => new BreathingActivity(),
                "2" => new ReflectionActivity(),
                "3" => new ListingActivity(),
                "4" => new VisualizationActivity(),
                "5" => null,
                _ => null
            };

            if (activity == null)
            {
                Console.WriteLine("Thank you for using the Mindfulness Program!");
                break;
            }

            Console.Clear();
            activity.Execute();
            ActivityLog.LogActivity(activity.GetType().Name); // Log the activity performed
            Console.WriteLine("\nPress any key to return to the main menu...");
            Console.ReadKey();  // Wait for the user to press a key before returning to the menu
        }
    }
}
// Mindfulness Program: Main Menu and Activity Execution

// This program includes four mindfulness activities: Breathing, Reflection, Listing, and Visualization.
// The user is prompted to choose an activity, and the activity is executed based on their selection.
// After completing an activity, the program logs the performed activity with a timestamp in a file for future reference.

// Exceeding Core Requirements:
// 1. **Logging Activity**: Every time a user completes an activity, the program logs the activity type and completion timestamp in a file called "activity_log.txt". This allows users to keep track of their past activities and review their mindfulness journey.
// 2. **Random Prompts for Reflection and Listing Activities**: The `ReflectionActivity` and `ListingActivity` use random prompts/questions from predefined lists. Once a prompt is used, it is removed to ensure variety and prevent repetition.
// 3. **Custom Countdown Animation**: For the Breathing and Reflection activities, a custom countdown animation is displayed, including text animations like "Breathe in..." and "Breathe out..." and a countdown timer, which adds to the interactive experience and makes the program more engaging.
// 4. **Pausing and Animation**: The program includes a custom pause function with a visual effect (dots) that simulates a countdown before starting each activity and between prompts. This gives a sense of anticipation and helps users focus more on the activity.
