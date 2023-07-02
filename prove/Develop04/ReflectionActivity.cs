// Reflection Activity
public class ReflectionActivity
{
    private int duration;
    private string[] prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] questions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity(int duration)
    {
        this.duration = duration;
    }

    public void Start()
    {
        Console.WriteLine("Reflection Activity");
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        Console.WriteLine("Get ready to begin.");
        Pause(3);

        Random random = new Random();
        int promptIndex = random.Next(prompts.Length);
        Console.WriteLine(prompts[promptIndex]);
        Pause(3);

        for (int i = 0; i < duration; i++)
        {
            int questionIndex = random.Next(questions.Length);
            Console.WriteLine(questions[questionIndex]);
            Pause(3);
        }
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
