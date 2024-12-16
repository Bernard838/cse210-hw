using System;
using System.IO;

public static class ActivityLog
{
    private static string logFilePath = "activity_log.txt";

    // Method to save activity data to file
    public static void LogActivity(string activityName)
    {
        string logMessage = $"{DateTime.Now}: {activityName} completed.";
        File.AppendAllText(logFilePath, logMessage + Environment.NewLine);
    }

    // Method to load activity log from file
    public static void LoadLog()
    {
        if (File.Exists(logFilePath))
        {
            string[] logEntries = File.ReadAllLines(logFilePath);
            Console.WriteLine("Activity Log:");
            foreach (var entry in logEntries)
            {
                Console.WriteLine(entry);
            }
        }
        else
        {
            Console.WriteLine("No activity log found.");
        }
    }
}
