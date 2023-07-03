public class BreathingActivity : Activity
{
    public BreathingActivity(int duration) : base(duration)
    {
    }

    public override void Start()
    {
        Console.WriteLine("===Breathing Activity===");
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        Console.WriteLine(" ");
        Console.WriteLine("Get ready to begin.");
        Pause(3000); 

        Console.WriteLine(" ");
        
        for (int i = 0; i < duration; i++)
        {
            Console.WriteLine("Breathe in...");
            Pause(3000); 
            Console.WriteLine("Breathe out...");
            Pause(3000); 
        }
    }
}