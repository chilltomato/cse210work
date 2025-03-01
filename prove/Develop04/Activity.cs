using System;
using System.Collections.Generic;
using System.Threading;

public abstract class Activity
{
    protected int Duration;
    protected List<string> Descriptions = new List<string>();

    public Activity(int duration)
    {
        Duration = duration;
    }

    public virtual void Start()
    {
        Console.WriteLine("\nStarting activity...");
        Console.WriteLine(Descriptions[0]);
        Anim.ShowLoadingAnim(5);            
        Console.Clear();
    }

    public virtual void End()
    {
        Console.WriteLine("Activity completed. Well done!\n");
        Console.WriteLine("Bringing you back to choose again\n");
        Anim.ShowLoadingAnim(5);            
        Console.Clear();

    }

    // Abstract method to be implemented by child classes
    public abstract void Run();
}
