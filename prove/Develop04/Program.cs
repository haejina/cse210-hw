class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("===== Activity Menu =====");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("0. Exit");

            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    BreathingActivity breathingActivity = new BreathingActivity(GetDurationFromUser());
                    RunActivity(breathingActivity);
                    break;
                case 2:
                    ReflectionActivity reflectionActivity = new ReflectionActivity(GetDurationFromUser());
                    RunActivity(reflectionActivity);
                    break;
                case 3:
                    ListingActivity listingActivity = new ListingActivity(GetDurationFromUser());
                    RunActivity(listingActivity);
                    break;
                case 0:
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    Console.ReadLine();
                    continue;
            }
        }
    }

    private static void RunActivity(Activity activity)
    {
        activity.Start();
        activity.End();
    }

    private static int GetDurationFromUser()
    {
        Console.Write("How long, in seconds, would you like for your session?");
        int duration = Convert.ToInt32(Console.ReadLine());
        return duration;
    }
}