namespace EternalQuest
{
    public class ChecklistGoal : Goal
    {
        private int TimesCompleted { get; set; }
        private int Target { get; set; }

        public ChecklistGoal(string name, int target)
        {
            Name = name;
            Target = target;
        }

        public override void RecordProgress()
        {
            if (TimesCompleted < Target)
            {
                TimesCompleted++;
                Points += 50; // Add points for each recorded instance
                Console.WriteLine($"Checklist goal '{Name}' recorded. Earned 50 points.");
                if (TimesCompleted == Target)
                {
                    Points += 500; // Bonus points on completion
                    Console.WriteLine($"Goal '{Name}' completed. Earned bonus {500} points!");
                }
            }
        }

        public override string GetGoalStatus()
        {
            return $"{Name} (Completed {TimesCompleted}/{Target} times)";
        }
    }
}
