public class MultiGoal : Goal
{
    private int TimesCompleted;
    private int RequiredCompletions;
    private float BonusPoints;

    public MultiGoal(string goal, float pointsAmount, int required, float bonus)
        : base(goal, pointsAmount)
    {
        RequiredCompletions = required;
        BonusPoints = bonus;
        TimesCompleted = 0;
    }

    public override bool IsComplete() => TimesCompleted >= RequiredCompletions;

    public override float RecordEvent()
    {
        if (IsComplete()) return 0;

        TimesCompleted++;
        if (TimesCompleted == RequiredCompletions)
        {
            CompletionDate = DateTime.Now;  
            return PointsAmount + BonusPoints;
        }

        return PointsAmount;
    }

    public override string GetGoalType() => "multi";

    public override string Serialize() =>
        $"multi|{GoalName}|{PointsAmount}|{CreationDate}|{CompletionDate}|{TimesCompleted}|{RequiredCompletions}|{BonusPoints}";
}
