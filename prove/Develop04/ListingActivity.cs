public class ListingActivity : Activity
{
    private string[] items = {
        "Write a to-do list",
        "List your favorite movies",
        "Write down your goals",
        "List things you are grateful for",
        "Make a list of places to visit",
        "List your hobbies and interests",
        "Write down your strengths and weaknesses"
    };

    public ListingActivity(int duration) : base(duration)
    {
    }

    public override void Start()
    {
        Console.WriteLine("===Listing Activity===");
        Console.WriteLine("This activity will help you organize your thoughts and ideas by creating various lists.");
        Console.WriteLine(" ");
        Console.WriteLine("Get ready to begin.");
        Pause(3000); 

        Random random = new Random();
        Console.WriteLine(" ");

        while (true)
        {
            int itemIndex = random.Next(items.Length);
            DisplayPrompt(items[itemIndex]);

            Pause(duration * 1000); 

            Console.WriteLine($"You have completed another {duration} seconds of the Listing Activity.");
            Pause(5000); 
        }
    }
}