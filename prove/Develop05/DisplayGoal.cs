using System;
using System.Collections.Generic;

public class DisplayGoal
{
    public void DisplayGoalSingle(string id, string type)
    {
        Console.WriteLine($"Goal: {id} | Type: {type}");
    }

    public void DisplayGoals(List<string> goals)
    {
        foreach (var goal in goals)
            Console.WriteLine(goal);
    }

    public void DisplayScore(float score)
    {
        Console.WriteLine($"Current Score: {score}");
    }
}
