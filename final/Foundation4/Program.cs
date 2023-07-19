using System;
using System.Collections.Generic;



class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        // Prompt the user to enter input for each activity
        Console.WriteLine("Enter Running activity details:");
        Console.Write("Date (dd/MM/yyyy): ");
        DateTime runningDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
        Console.Write("Duration (in minutes): ");
        int runningMinutes = int.Parse(Console.ReadLine());
        Console.Write("Distance (in kilometers): ");
        double runningDistance = double.Parse(Console.ReadLine());

        Console.WriteLine("\nEnter Cycling activity details:");
        Console.Write("Date (dd/MM/yyyy): ");
        DateTime cyclingDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
        Console.Write("Duration (in minutes): ");
        int cyclingMinutes = int.Parse(Console.ReadLine());
        Console.Write("Speed (in km/h): ");
        double cyclingSpeed = double.Parse(Console.ReadLine());

        Console.WriteLine("\nEnter Swimming activity details:");
        Console.Write("Date (dd/MM/yyyy): ");
        DateTime swimmingDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
        Console.Write("Duration (in minutes): ");
        int swimmingMinutes = int.Parse(Console.ReadLine());
        Console.Write("Laps: ");
        int swimmingLaps = int.Parse(Console.ReadLine());

        // Create activity objects and add them to the list
        activities.Add(new Running(runningDate, runningMinutes, runningDistance));
        activities.Add(new Cycling(cyclingDate, cyclingMinutes, cyclingSpeed));
        activities.Add(new Swimming(swimmingDate, swimmingMinutes, swimmingLaps));

        // Display the summary for each activity
        Console.WriteLine("\nActivity Summaries:");
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
