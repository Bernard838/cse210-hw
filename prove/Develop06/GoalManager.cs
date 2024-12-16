using System;
using System.Collections.Generic;
using System.IO;

namespace EternalQuest
{
    public static class GoalManager
    {
        public static void SaveGoalsToFile(List<Goal> goals, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (Goal goal in goals)
                {
                    writer.WriteLine($"{goal.GetType().Name}:{goal.Name}:{goal.Points}");
                }
            }
        }

        public static List<Goal> LoadGoalsFromFile(string filePath)
        {
            List<Goal> loadedGoals = new List<Goal>();

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(':');
                    string goalType = parts[0];
                    string name = parts[1];
                    int points = int.Parse(parts[2]);

                    if (goalType == "SimpleGoal")
                    {
                        loadedGoals.Add(new SimpleGoal { Name = name, Points = points });
                    }
                    else if (goalType == "EternalGoal")
                    {
                        loadedGoals.Add(new EternalGoal { Name = name, Points = points });
                    }
                    else if (goalType == "ChecklistGoal")
                    {
                        loadedGoals.Add(new ChecklistGoal(name, points)); // Adjust this as needed
                    }
                }
            }

            return loadedGoals;
        }
    }
}
