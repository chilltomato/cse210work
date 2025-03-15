public class ReflectingActivity : Activity
{
    private List<string> ReflectPrompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you stood up to someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you asked for help."
    };

    private List<string> ReflectQuestions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "How did you feel when it was complete?",
        "What did you learn about yourself through this experience?",
        "Did you regret this experience? if so, why did you?",
        "What would you do differently if you could go back?",
        "Do you think you did the correct thing? why or why not?",
    };

    public ReflectingActivity(int duration) : base(duration)
    {
        Descriptions.Add("Lets reflect on ourselfs for awhile.");
    }

    public override void Run()
    {
        Start();
        Random rand = new Random();
        Console.WriteLine("\n" + ReflectPrompts[rand.Next(ReflectPrompts.Count)] + "\n");
        
        Console.WriteLine("\nPress Enter when you are ready to reflect on it");
        Console.ReadLine();  // Wait for the user to press Enter
        Thread.Sleep(500);

        Console.Clear();

        int elapsedTime = 0;
        while (elapsedTime < Duration)
        {
            Console.WriteLine(ReflectQuestions[rand.Next(ReflectQuestions.Count)]);
            Anim.ShowLoadingAnim(3,1);            
            elapsedTime += 3;
        }

        End();
    }
}
