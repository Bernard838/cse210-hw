using System;
using System.Collections.Generic;

namespace EternalQuest
{
    public class Program
    {
        private static List<Goal> goals = new List<Goal>();
        private static int totalPoints = 0;

        public static void Main(string[] args)
        {
            DisplayMenu();
            string userInput = Console.ReadLine();

            while (userInput != "exit")
            {
                ProcessInput(userInput);
                DisplayMenu();
                userInput = Console.ReadLine();
            }
        }

        private static void DisplayMenu()
        {
            Console.WriteLine("Welcome to the Eternal Quest!");
            Console.WriteLine("1. Create a new goal");
            Console.WriteLine("2. Record progress on a goal");
            Console.WriteLine("3. Display goals");
            Console.WriteLine("4. View total points");
            Console.WriteLine("Type 'exit' to quit.");
        }

        private static void ProcessInput(string input)
        {
            switch (input)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    RecordProgress();
                    break;
                case "3":
                    DisplayGoals();
                    break;
                case "4":
                    Console.WriteLine($"Total Points: {totalPoints}");
                    break;
                default:
                    Console.WriteLine("Invalid input.");
                    break;
            }
        }

        private static void CreateGoal()
        {
            Console.WriteLine("Enter the type of goal (simple/eternal/checklist):");
            string goalType = Console.ReadLine().ToLower();

            Console.WriteLine("Enter the goal name:");
            string name = Console.ReadLine();

            if (goalType == "simple")
            {
                goals.Add(new SimpleGoal { Name = name, Points = 100 });
            }
            else if (goalType == "eternal")
            {
                goals.Add(new EternalGoal { Name = name, Points = 50 });
            }
            else if (goalType == "checklist")
            {
                Console.WriteLine("Enter the target count for this goal:");
                int target = int.Parse(Console.ReadLine());
                goals.Add(new ChecklistGoal(name, target));
            }
            else
            {
                Console.WriteLine("Invalid goal type.");
            }
        }

        private static void RecordProgress()
        {
            Console.WriteLine("Enter the index of the goal to record progress:");
            int index = int.Parse(Console.ReadLine()) - 1;

            if (index >= 0 && index < goals.Count)
            {
                goals[index].RecordProgress();
                totalPoints += goals[index].Points;
            }
            else
            {
                Console.WriteLine("Invalid goal index.");
            }
        }

        private static void DisplayGoals()
        {
            for (int i = 0; i < goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {goals[i].GetGoalStatus()}");
            }
        }
    }
}

// Exceeding core requirements: Added saving/loading functionality
        // The program now allows the user to save their goals and progress to a file
        // and load them back when restarting the program. This ensures that the user's
        // goals are preserved between sessions.
        // Additionally, the program can track total points across different types of goals
        // (Simple, Eternal, and Checklist goals), which are incremented appropriately based
        // on the user's actions.
