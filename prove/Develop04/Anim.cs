public static class Anim
{
    public static void ShowLoadingAnim(int durationInSeconds)
    {
        string[] AnimFrames = { "0", "o", "-", "o" };
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
