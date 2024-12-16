namespace EternalQuest
{
    public abstract class Goal
    {
        public string Name { get; set; }
        public int Points { get; set; }

        // Abstract method for recording progress
        public abstract void RecordProgress();

        // Abstract method for displaying goal status
        public abstract string GetGoalStatus();
    }
}
