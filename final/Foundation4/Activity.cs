using System;
using System.Collections.Generic;

class Activity
{
    protected DateTime date;
    protected int minutes;

    public Activity(DateTime date, int minutes)
    {
        this.date = date;
        this.minutes = minutes;
    }

    protected virtual double GetDistance()
    {
        return 0;
    }

    protected virtual double GetSpeed()
    {
        return 0;
    }

    protected virtual double GetPace()
    {
        return 0;
    }

    public string GetSummary()
    {
        return $"{date:dd MMM yyyy} {this.GetType().Name} ({minutes} min) - " +
               $"Distance: {GetDistance():F1} km, Speed: {GetSpeed():F1} kph, Pace: {GetPace():F1} min per km";
    }
}
