
public class ActivityInput
{
    public void StartActivity()
    {
        while (true)
        {
            Console.WriteLine("tell me, what activity do you want to pick?");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            if (choice == "4") break;

            Console.Write("Enter duration (in seconds): ");
            int duration;
            if (!int.TryParse(Console.ReadLine(), out duration))
            {
                Console.WriteLine("Invalid input. Try again.");
                continue;
            }

            Activity activity = null;

            switch (choice)
            {
                case "1":
                    activity = new BreathingActivity(duration);
                    break;
                case "2":
                    activity = new ReflectingActivity(duration);
                    break;
                case "3":
                    activity = new ListingActivity(duration);
                    break;
                case "-1": // don't remember this being here, huh
                           //try it out, wonder what it does
                activity = new SecretActivity(duration);
                break;
                default:
                    Console.WriteLine("Invalid choice.");
                    continue;
            }

            activity.Run(); // Calls the respective Run() method of the chosen activity
        }
        Console.Write("come back soon");
    }
}
