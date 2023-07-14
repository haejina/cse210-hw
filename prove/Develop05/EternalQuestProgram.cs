public class EternalQuestProgram
{
    private List<Goal> goals;
    private int score;

    public EternalQuestProgram()
    {
        goals = new List<Goal>();
        score = 0;
    }

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void RecordEvent(int index)
    {
        if (index >= 0 && index < goals.Count)
        {
            Goal goal = goals[index];
            if (!goal.Completed)
            {
                score += goal.CalculatePoints();
                goal.Completed = true;
                Console.WriteLine("Event recorded successfully!");
            }
            else
            {
                Console.WriteLine("Goal already completed!");
            }
        }
        else
        {
            Console.WriteLine("Invalid goal index!");
        }
    }

    public void DisplayGoals()
{
    Console.WriteLine("The goals are:");

    for (int i = 0; i < goals.Count; i++)
    {
        Goal goal = goals[i];
        string status = goal.Completed ? "[X]" : "[ ]";

        if (goal is ChecklistGoal checklistGoal)
        {
            Console.WriteLine($"{i + 1}. {status} {goal.Name} (Completed {checklistGoal.CompletionCount}/{checklistGoal.TargetCount} times)");
        }
        else
        {
            Console.WriteLine($"{i + 1}. {status} {goal.Name}");
        }
      }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Current score: {score}");
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Goal goal in goals)
            {
                writer.WriteLine($"{goal.GetType().Name},{goal.Name},{goal.Value},{goal.Completed}");
                if (goal is ChecklistGoal checklistGoal)
                {
                    writer.WriteLine(checklistGoal.TargetCount);
                    writer.WriteLine(checklistGoal.CompletionCount);
                }
            }
        }
        Console.WriteLine("Goals saved successfully!");
    }

    public List<Goal> LoadGoals(string filename)
{
    List<Goal> loadedGoals = new List<Goal>();

    if (File.Exists(filename))
    {
        using (StreamReader reader = new StreamReader(filename))
        {
            while (!reader.EndOfStream)
            {
                string goalType = reader.ReadLine();
                string name = reader.ReadLine();
                int value;
                bool valueParsed = int.TryParse(reader.ReadLine(), out value);
                bool completed;
                bool completedParsed = bool.TryParse(reader.ReadLine(), out completed);

                Goal goal;
                if (goalType == "SimpleGoal")
                {
                    goal = new SimpleGoal();
                }
                else if (goalType == "EternalGoal")
                {
                    goal = new EternalGoal();
                }
                else if (goalType == "ChecklistGoal")
                {
                    goal = new ChecklistGoal();
                    int targetCount;
                    bool targetCountParsed = int.TryParse(reader.ReadLine(), out targetCount);
                    if (!targetCountParsed)
                    {
                        // Handle invalid target count
                        continue;
                    }

                    int completionCount;
                    bool completionCountParsed = int.TryParse(reader.ReadLine(), out completionCount);
                    if (!completionCountParsed)
                    {
                        // Handle invalid completion count
                        continue;
                    }

                    ((ChecklistGoal)goal).TargetCount = targetCount;
                    ((ChecklistGoal)goal).CompletionCount = completionCount;
                }
                else
                {
                    continue; // Skip invalid goal types
                }

                goal.Name = name;
                goal.Value = valueParsed ? value : 0;
                goal.Completed = completedParsed ? completed : false;
                loadedGoals.Add(goal);
            }
        }
        Console.WriteLine("Goals loaded successfully!");
    }
    else
    {
        Console.WriteLine("Goals file not found!");
    }

    return loadedGoals;
}

public void ListGoals()
{
    Console.WriteLine("The goals are:");

    for (int i = 0; i < goals.Count; i++)
    {
        Goal goal = goals[i];
        string status = goal.Completed ? "[X]" : "[ ]";

        if (goal is ChecklistGoal checklistGoal)
        {
            Console.WriteLine($"{i + 1}. {status} {goal.Name} (Completed {checklistGoal.CompletionCount}/{checklistGoal.TargetCount} times)");
        }
        else
        {
            Console.WriteLine($"{i + 1}. {status} {goal.Name}");
        }
    }
}


}