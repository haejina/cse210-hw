// Listing Activity
public class ListingActivity
{
    private int duration;
    private string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(int duration)
    {
        this.duration = duration;
    }

    public void Start()
    {
        Console.WriteLine("Listing Activity");
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        Console.WriteLine("Get ready to begin.");
        Pause(3);

        Random random = new Random();
        int promptIndex = random.Next(prompts.Length);
        Console.WriteLine(prompts[promptIndex]);
        Pause(3);
        Console.WriteLine("Start listing:");

        int count = 0;
        DateTime startTime = DateTime.Now;
        TimeSpan timeElapsed;

        do
        {
            string item = Console.ReadLine();
            count++;
            timeElapsed = DateTime.Now - startTime;
        }
        while (timeElapsed.TotalSeconds < duration);

        Console.WriteLine($"Total items listed: {count}");
    }

    public void End()
    {
        Console.WriteLine($"Well done!,You have completed {duration} seconds of the Reflection Activity.");
        Pause(5000); // 5000 milliseconds = 5 seconds
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

    private void Pause(int milliseconds)
    {
        Thread.Sleep(milliseconds);
    }
}
