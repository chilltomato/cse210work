using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        SaveData saver = new SaveData();
        float totalScore = 0;
        List<Goal> goals = new List<Goal>();
        DisplayGoal display = new DisplayGoal();
        CreateGoal creator = new CreateGoal();

        Console.WriteLine("Welcome to the Goal Tracker! It tracks Goals.");

        bool running = true;
        while (running)
        {
            Console.WriteLine("\nChoose an option from the list:\n1. Record Event\n2. Show Goals\n3. Show Score\n4. Save Goals\n5. Add Custom Goal\n6. Load Goals\n7. Exit");
            var input = Console.ReadLine();
            Console.Clear(); // Clear the screen after reading input

            switch (input)
            {
                case "1":
                    if (goals.Count == 0)
                    {
                        Console.WriteLine("Excuse me but you don't have any goals rn!");
                        break;
                    }

                    Console.WriteLine("Which goal have you completed?");
                    for (int i = 0; i < goals.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {goals[i].GoalName} ({goals[i].GetType().Name})");
                    }

                    Console.Write("Choose the goal number you want to record: ");
                    if (int.TryParse(Console.ReadLine(), out int choice) && choice > 0 && choice <= goals.Count)
                    {
                        float earned = goals[choice - 1].RecordEvent();
                        totalScore += earned;
                        Console.WriteLine($"You earned {earned} points for completing the goal '{goals[choice - 1].GoalName}'!");

                        var completionTime = goals[choice - 1].GetCompletionTime();
                        if (completionTime != "Not completed yet")
                        {
                            Console.WriteLine($"It took you {completionTime} to complete the goal.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid goal choice.");
                    }
                    break;

                case "2":
                    if (goals.Count == 0)
                    {
                        Console.WriteLine("Excuse me but you don't have any goals rn!");
                        break;
                    }

                    Console.WriteLine("Your current goals:\n");
                    foreach (var goal in goals)
                    {
                        Console.WriteLine($"Goal: {goal.GoalName} | Type: {goal.GetGoalType()} | Points: {goal.PointsAmount}");
                        Console.WriteLine($"Created on: {goal.CreationDate}");

                        var completionTime = goal.GetCompletionTime();
                        if (completionTime != "Not completed yet")
                            Console.WriteLine($"Completion Time: {completionTime}");
                        else
                            DisplayGoalDuration(goal);

                        Console.WriteLine();
                    }
                    break;

                case "3":
                    display.DisplayScore(totalScore);
                    break;

                case "4":
                    saver.SaveGoals(goals, totalScore);
                    Console.WriteLine("Goals saved successfully.");
                    break;

                case "5":
                    Console.Write("what goal type do you want? (simple/eternal/multi) ");
                    string gtype = Console.ReadLine().ToLower();

                    Console.Write("What should the goal be called? ");
                    string name = Console.ReadLine();

                    Console.Write("Enter points: ");
                    if (!float.TryParse(Console.ReadLine(), out float points))
                    {
                        Console.WriteLine("Invalid points input.");
                        break;
                    }

                    if (gtype == "simple")
                    {
                        goals.Add(new SimpleGoal(name, points));
                    }
                    else if (gtype == "eternal")
                    {
                        goals.Add(new EternalGoal(name, points));
                    }
                    else if (gtype == "multi")
                    {
                        Console.Write("how many times do you need to record it before it's completed? ");
                        if (!int.TryParse(Console.ReadLine(), out int required))
                        {
                            Console.WriteLine("Invalid input for required times.");
                            break;
                        }

                        Console.Write("how many bonus points will you recive after completing it? ");
                        if (!float.TryParse(Console.ReadLine(), out float bonus))
                        {
                            Console.WriteLine("Invalid bonus input.");
                            break;
                        }

                        goals.Add(new MultiGoal(name, points, required, bonus));
                    }
                    else
                    {
                        Console.WriteLine("Invalid goal type.");
                    }
                    break;

                case "6":
                    var result = saver.LoadGoals();
                    goals = result.Item1;
                    totalScore = result.Item2;
                    Console.WriteLine("Goals loaded successfully.");
                    break;

                case "7":
                    Console.WriteLine("Goodbye!");
                    running = false;
                    break;

                default:
                    Console.WriteLine("That option doesn't exist. Try again please.");
                    Thread.Sleep(500);
                    break;
            }

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
            Console.Clear(); // Clear again after each case before going to next loop
        }

        Console.WriteLine("Thanks for using Goal Tracker!");
    }

    public static void DisplayGoalDuration(Goal goal)
    {
        TimeSpan duration = DateTime.Now - goal.CreationDate;
        Console.WriteLine($"(Uncompleted for: {duration.Days} days)");
    }
}
