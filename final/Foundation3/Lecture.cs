using System;
public class Lecture : Event
{
    private string speaker;
    private int capacity;

    public Lecture(string title, string description, DateTime date, TimeSpan time, Address address)
        : base(title, description, date, time, address)
    {
    }

    public string Speaker
    {
        get { return speaker; }
        set { speaker = value; }
    }

    public int Capacity
    {
        get { return capacity; }
        set { capacity = value; }
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nType: Lecture\nSpeaker: {speaker}\nCapacity: {capacity}";
    }
}
