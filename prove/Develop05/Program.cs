using System;

public class Program
{
    public static void Main()
    {
        EternalQuestProgram program = new EternalQuestProgram();
        string goalsFilename = "goals.txt";
        program.LoadGoals(goalsFilename);

        Console.WriteLine("Welcome to Eternal Quest Program!");
        Console.WriteLine("You have 0 points.");

        bool quit = false;
        while (!quit)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Create new goal");
            Console.WriteLine("2. Load Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Record Events");
            Console.WriteLine("5. Quit");

            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal(program);
                    break;
                case "2":
                    program.LoadGoals(goalsFilename);
                    program.ListGoals();
                    break;
                case "3":
                    program.SaveGoals(goalsFilename);
                    break;
                case "4":
                    RecordEvent(program);
                    break;
                case "5":
                    quit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }

    public static void CreateGoal(EternalQuestProgram program)
{
    Console.WriteLine("Create a new goal:");
    
    Console.WriteLine("Select the goal type:");
    Console.WriteLine("1. Simple Goal");
    Console.WriteLine("2. Eternal Goal");
    Console.WriteLine("3. Checklist Goal");

    Console.Write("Enter the goal type: ");
    string goalTypeStr = Console.ReadLine();
    if (!int.TryParse(goalTypeStr, out int goalType))
    {
        Console.WriteLine("Invalid input. Please enter a valid goal type.");
        return;
    }

    Console.Write("What is the name of your goal? ");
    string name = Console.ReadLine();

    Console.Write("What is a short description of it? ");
    string description = Console.ReadLine();

    Console.Write("What is the amount of points associated with this goal? ");
    int value;
    while (!int.TryParse(Console.ReadLine(), out value))
    {
        Console.WriteLine("Invalid input. Please enter a valid integer value.");
    }

    Goal goal;
    switch (goalType)
    {
        case 1:
            goal = new SimpleGoal();
            break;
        case 2:
            goal = new EternalGoal();
            break;
        case 3:
            int targetCount;
            do
            {
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            }
            while (!int.TryParse(Console.ReadLine(), out targetCount) || targetCount <= 0);

            int bonus;
            do
            {
                Console.Write("What is the bonus for accomplishing it that many times? ");
            }
            while (!int.TryParse(Console.ReadLine(), out bonus) || bonus <= 0);

            goal = new ChecklistGoal()
            {
                TargetCount = targetCount,
                Bonus = bonus
            };
            break;
        default:
            Console.WriteLine("Invalid goal type.");
            return;
    }

    goal.Name = name;
    goal.Description = description;
    goal.Value = value;

    program.AddGoal(goal);
    Console.WriteLine("Goal created successfully!");
}


    public static void RecordEvent(EternalQuestProgram program)
    {
        program.DisplayGoals();

        Console.Write("Enter the index of the goal you want to record an event for: ");
        string indexStr = Console.ReadLine();
        if (int.TryParse(indexStr, out int index))
        {
            program.RecordEvent(index - 1);
        }
        else
        {
            Console.WriteLine("Invalid index!");
        }
    }
}
