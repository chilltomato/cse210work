public abstract class Goal
{
    public float PointsAmount;
    public string GoalName { get; set; }
    public DateTime CreationDate { get; set; }
    public DateTime? CompletionDate { get; set; }  

    public Goal(string goalName, float pointsAmount)
    {
        GoalName = goalName;
        PointsAmount = pointsAmount;
        CreationDate = DateTime.Now;  
        CompletionDate = null;  
    }

    public abstract bool IsComplete();
    public abstract float RecordEvent();
    public abstract string GetGoalType(); 
    public abstract string Serialize();

    public string GetCompletionTime()
    {
        if (CompletionDate == null) return "Not completed yet.";

        TimeSpan timeTaken = CompletionDate.Value - CreationDate;
        return $"Completed in {timeTaken.Days} days, {timeTaken.Hours} hours, and {timeTaken.Minutes} minutes.";
    }
}
