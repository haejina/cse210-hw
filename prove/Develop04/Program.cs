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
                    Console.Write("How long, in seconds, would you like for your session?");
                    int breathingDuration = Convert.ToInt32(Console.ReadLine());
                    BreathingActivity breathingActivity = new BreathingActivity(breathingDuration);
                    RunActivity(breathingActivity);
                    break;
                case 2:
                    Console.Write("How long, in seconds, would you like for your session?");
                    int reflectionDuration = Convert.ToInt32(Console.ReadLine());
                    ReflectionActivity reflectionActivity = new ReflectionActivity(reflectionDuration);
                    RunActivity(reflectionActivity);
                    break;
                case 3:
                    Console.Write("How long, in seconds, would you like for your session?");
                    int listingDuration = Convert.ToInt32(Console.ReadLine());
                    ListingActivity listingActivity = new ListingActivity(listingDuration);
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

    private static void RunActivity(object activity)
    {
        if (activity is BreathingActivity breathingActivity)
        {
            breathingActivity.Start();
            breathingActivity.End();
        }
        else if (activity is ReflectionActivity reflectionActivity)
        {
            reflectionActivity.Start();
            reflectionActivity.End();
        }
        else if (activity is ListingActivity listingActivity)
        {
            listingActivity.Start();
            listingActivity.End();
        }
    }
}