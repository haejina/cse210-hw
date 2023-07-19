class Swimming : Activity
{
    private int laps;

    public Swimming(DateTime date, int minutes, int laps) : base(date, minutes)
    {
        this.laps = laps;
    }

    protected override double GetDistance()
    {
        return laps * 50 / 1000.0;
    }

    protected override double GetSpeed()
    {
        return (GetDistance() / minutes) * 60;
    }

    protected override double GetPace()
    {
        return minutes / GetDistance();
    }
}
