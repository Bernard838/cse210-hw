namespace EternalQuest
{
    public class EternalGoal : Goal
    {
        private int Progress { get; set; }

        public override void RecordProgress()
        {
            Progress++;
            Console.WriteLine($"Eternal goal '{Name}' recorded. Earned {Points} points.");
        }

        public override string GetGoalStatus()
        {
            return $"{Name} (Progress: {Progress} times)";
        }
    }
}
