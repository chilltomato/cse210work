public class BreathingActivity : Activity
{
    public BreathingActivity(int duration) : base(duration)
    {
        Descriptions.Add("lets focus on our breathing for a while.");
    }

    public override void Run()
    {
            Start();
            Console.WriteLine("Breathe in when I say Breathe in.");
            Console.WriteLine("Breathe out when I say Breathe in.");
            Thread.Sleep(2000);
            Console.Clear();
        for (int i = 0; i < Duration; i += 2)
        {
            Console.WriteLine("Breathe in...");
            Anim.ShowLoadingAnim(2,3);            
            Console.WriteLine("Breathe out...");
            Anim.ShowLoadingAnim(2,2);            
        }
        End();
    }
}
