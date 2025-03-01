using System;
using System.Threading;

public class SecretActivity : Activity
{
    public SecretActivity(int duration) : base(duration)
    {
        Descriptions.Add("Invalid... wait, there's a secret here. lets run it.");
    }

    public override void Run()
    {
        Start();
        Console.WriteLine("how did you get here? your not supposed to be here");
        Thread.Sleep(500);
        Console.WriteLine("well since your here, I have a question.");
        Thread.Sleep(500);

        Console.WriteLine("What is your favorite word?");
        string answer = Console.ReadLine();

        Console.WriteLine($"very Interesting!");
        Thread.Sleep(500);
        Console.WriteLine($"'{answer}'");
        Thread.Sleep(500);
        Console.WriteLine($"'reflect on why you like that word for the next {Duration} seconds'");
        Anim.ShowLoadingAnim(Duration);           
        Console.WriteLine($"what did you think? liked anything in particular?");
        Thread.Sleep(500);
        Console.WriteLine($"wasted too much of your time, we'll meet again.");
        Anim.ShowLoadingAnim(5);            

        End();
    }
}
