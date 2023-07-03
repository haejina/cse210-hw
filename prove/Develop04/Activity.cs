using System;
using System.Threading;


public abstract class Activity
{
    protected int duration;

    public Activity(int duration)
    {
        this.duration = duration;
    }

    public abstract void Start();

    public virtual void End()
    {
        Console.WriteLine(" ");
        Console.WriteLine("well done :)");
        Console.WriteLine(" ");
        Console.WriteLine($"You have completed {duration} seconds of the Reflection Activity.");
        Pause(5000); 
        Console.WriteLine(" ");
        Console.WriteLine("Press any key to continue.");
        Console.ReadKey();
    }

    protected void Pause(int milliseconds)
    {
        Thread.Sleep(milliseconds);
    }

    protected void DisplayPrompt(string prompt)
    {
        Console.WriteLine(prompt);
        Pause(3000); 
    }
}