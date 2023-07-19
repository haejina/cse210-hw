class Running : Activity
{
    private double distance;

    public Running(DateTime date, int minutes, double distance) : base(date, minutes)
    {
        this.distance = distance;
    }

    protected override double GetDistance()
    {
        return distance;
    }

    protected override double GetSpeed()
    {
        return (distance / minutes) * 60;
    }

    protected override double GetPace()
    {
        return minutes / distance;
    }
}
