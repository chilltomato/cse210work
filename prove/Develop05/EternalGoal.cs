public class EternalGoal : Goal
{
    private int TimesCompleted;

    public EternalGoal(string goal, float pointsAmount) : base(goal, pointsAmount)
    {
        TimesCompleted = 0;
    }

    public override bool IsComplete() => false;

    public override float RecordEvent()
    {
        TimesCompleted++;
        if (TimesCompleted == 1)  
            CompletionDate = DateTime.Now;
        return PointsAmount;
    }

    public override string GetGoalType() => "eternal";

    public override string Serialize() =>
        $"eternal|{GoalName}|{PointsAmount}|{CreationDate}|{CompletionDate}";
}
