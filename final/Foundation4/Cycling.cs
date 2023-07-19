class Cycling : Activity
{
    private double speed;

    public Cycling(DateTime date, int minutes, double speed) : base(date, minutes)
    {
        this.speed = speed;
    }

    protected override double GetSpeed()
    {
        return speed;
    }

    protected override double GetDistance()
    {
        return (speed / 60) * minutes;
    }

    protected override double GetPace()
    {
        return 60 / speed;
    }
}
