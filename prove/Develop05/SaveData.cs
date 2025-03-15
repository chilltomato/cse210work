public class SaveData
{
    public void SaveGoals(List<Goal> goals, float score)
    {
        Console.Write("Enter filename to save goals: ");
        string fileName = Console.ReadLine();

        if (!fileName.EndsWith(".txt"))
            fileName += ".txt";

        using (StreamWriter writer = new StreamWriter(fileName))
        {
            writer.WriteLine(score);
            foreach (var goal in goals)
                writer.WriteLine(goal.Serialize());
        }
    }

    public (List<Goal>, float) LoadGoals()
    {
        List<Goal> goals = new List<Goal>();
        float score = 0;

        Console.Write("Enter the filename where your goals is saved: ");
        string fileName = Console.ReadLine();

        if (!File.Exists(fileName))
        {
            Console.WriteLine("File not found.");
            return (goals, score);
        }

        string[] lines = File.ReadAllLines(fileName);
        if (lines.Length == 0) return (goals, score);

        score = float.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');
            string type = parts[0];

            switch (type)
            {
                case "simple":
                    var sgoal = new SimpleGoal(parts[1], float.Parse(parts[2]));
                    sgoal.CreationDate = DateTime.Parse(parts[3]);
                    sgoal.CompletionDate = string.IsNullOrEmpty(parts[4]) ? (DateTime?)null : DateTime.Parse(parts[4]);
                    goals.Add(sgoal);
                    break;

                case "eternal":
                    var egoal = new EternalGoal(parts[1], float.Parse(parts[2]));
                    egoal.CreationDate = DateTime.Parse(parts[3]);
                    egoal.CompletionDate = string.IsNullOrEmpty(parts[4]) ? (DateTime?)null : DateTime.Parse(parts[4]);
                    goals.Add(egoal);
                    break;

                case "multi":
                    var mgoal = new MultiGoal(parts[1], float.Parse(parts[2]), int.Parse(parts[4]), float.Parse(parts[5]));
                    mgoal.CreationDate = DateTime.Parse(parts[3]);
                    mgoal.CompletionDate = string.IsNullOrEmpty(parts[4]) ? (DateTime?)null : DateTime.Parse(parts[4]);
                    goals.Add(mgoal);
                    break;
            }
        }

        return (goals, score);
    }
}
