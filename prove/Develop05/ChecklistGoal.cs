public class ChecklistGoal : Goal
{
    public int TargetCount { get; set; }
    public int CompletionCount { get; set; }
    public int Bonus { get; set; }

    public new string Description { get; set; }

    public override int CalculatePoints()
    {
        return Value;
    }
}
