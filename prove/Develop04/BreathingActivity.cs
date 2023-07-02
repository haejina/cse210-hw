using System;
using System.Threading;

// Breathing Activity
public class BreathingActivity
{
    private int duration;

    public BreathingActivity(int duration)
    {
        this.duration = duration;
    }

    public void Start()
    {
        Console.WriteLine("Breathing Activity");
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        Console.WriteLine("Get ready to begin.");
        Pause(3000); // 3000 milliseconds = 3 seconds

        for (int i = 0; i < duration; i++)
        {
            Console.WriteLine("Breathe in...");
            Pause(3000); // 3000 milliseconds = 3 seconds
            Console.WriteLine("Breathe out...");
            Pause(3000); // 3000 milliseconds = 3 seconds
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