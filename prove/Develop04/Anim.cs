public static class Anim
{
    public static void ShowLoadingAnim(int durationInSeconds, int animationId)
    {
        string[][] animations = {
            new string[] { "|", "/", "-", "\\" },
            new string[] { "0", "o", "-", "o" },
            new string[] { "0", "o", "o", "o" },
            new string[] { "o", "0", "0", "0" },
        };

        string[] AnimFrames = animations[animationId % animations.Length];
        int counter = 0;

        DateTime endTime = DateTime.Now.AddSeconds(durationInSeconds);
        while (DateTime.Now < endTime)
        {
            Console.Write(AnimFrames[counter % 4]);
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            Thread.Sleep(300);
            counter++;
        }
    }
}
