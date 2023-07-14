public abstract class Goal
{
    public string Name { get; set; }
    public int Value { get; set; }
    public bool Completed { get; set; }
    public string Description { get; set; } // Added property

    public abstract int CalculatePoints();
}
