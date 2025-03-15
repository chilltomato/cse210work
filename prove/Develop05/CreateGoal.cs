public class CreateGoal
{
    public Goal CreateGoalFromType(string type)
    {
        if (type == "simple")
            return new SimpleGoal("Run a Marathon", 1000);
        else if (type == "eternal")
            return new EternalGoal("Read Scriptures", 100);
        else if (type == "multi")
            return new MultiGoal("Attend Temple", 50, 10, 500);
        else
            throw new Exception("Invalid goal type.");
    }
}
