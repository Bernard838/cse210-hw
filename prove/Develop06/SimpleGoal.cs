namespace EternalQuest
{
    public class SimpleGoal : Goal
    {
        private bool IsComplete { get; set; }

        public override void RecordProgress()
        {
            if (!IsComplete)
            {
                IsComplete = true;
                Console.WriteLine($"Goal '{Name}' completed! Earned {Points} points.");
            }
        }

        public override string GetGoalStatus()
        {
            return IsComplete ? $"[X] {Name}" : $"[ ] {Name}";
        }
    }
}
