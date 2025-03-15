public class SimpleGoal : Goal
{
    private bool Complete;

    public SimpleGoal(string goal, float pointsAmount) : base(goal, pointsAmount)
    {
        Complete = false;
    }

    public override bool IsComplete() => Complete;

    public override float RecordEvent()
    {
        if (!Complete)
        {
            Complete = true;
            CompletionDate = DateTime.Now;  
            return PointsAmount;
        }
        return 0;
    }

    public override string GetGoalType() => "simple";

    public override string Serialize() =>
        $"simple|{GoalName}|{PointsAmount}|{CreationDate}|{CompletionDate}";
}
