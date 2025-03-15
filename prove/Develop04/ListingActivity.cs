using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

public class ListingActivity : Activity
{
    private List<string> ListingPrompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are your personal strengths?",
        "Who are people you have helped this week?",
        "What are some times you felt hevean this week?",
        "What are some things you are looking forward to?",
        "What are some things you are grateful for?",
        "What are some things you are proud of?",
        "Why do you think you are a good person?",
        "What are some things you are excited about?",
    };

    private List<string> UserInputs = new List<string>();

    public ListingActivity(int duration) : base(duration)
    {
        Descriptions.Add("Get ready to list some things about you.");
    }

    public override void Run()
    {
        Start();
        Random rand = new Random();
        Console.WriteLine($"\n list as many answers as you can to the question {ListingPrompts[rand.Next(ListingPrompts.Count)]} \n");
        Console.WriteLine("You have " + Duration + " seconds. Start listing!");
        Anim.ShowLoadingAnim(2,1);            

        int elapsedTime = 0;

        Thread timeThread = new Thread(() =>
        {
            while (elapsedTime < Duration)
            {
                Thread.Sleep(1000); // Update time every second
                elapsedTime++;
            }
        });

        timeThread.Start();

        while (elapsedTime < Duration)
        {
            Console.Write(">");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
                UserInputs.Add(input);
        }
        
        timeThread.Join();

        if (UserInputs.Count > 0){
            Console.WriteLine($"\nYou listed {UserInputs.Count} items, more that I could ever");
        }
        else{
           Console.WriteLine($"\nYou listed {UserInputs.Count} items, exactly the same as me.");        
        }

        SaveToFile();
        End();
    }

    private void SaveToFile()
    {
        Console.Write("What filename do you want when I save your list (without extension): ");
        string fileName = Console.ReadLine();
        
        if (!fileName.EndsWith(".txt"))
        {
            fileName += ".txt";
        }

        File.AppendAllLines(fileName, UserInputs);
        Console.WriteLine($"You can find your list at {fileName}");
    }
}