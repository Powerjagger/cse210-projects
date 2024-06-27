using System;

class Program
{
    static void Main(string[] args)
    {
        GoalCollection goals = new GoalCollection();
        goals.InitializeTasks();

        bool running = true;

        while (running)
        {
            Console.WriteLine("\n--- Goal Management System ---");
            Console.WriteLine("1. Show Goals");
            Console.WriteLine("2. Add New Goal");
            Console.WriteLine("3. Record an Event");
            Console.WriteLine("4. Show Score");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Exit");

            Console.Write("Select an option: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    goals.PrintGoals();
                    break;
                case "2":
                    AddNewGoal(goals);
                    break;
                case "3":
                    RecordEvent(goals);
                    break;
                case "4":
                    Console.WriteLine($"Current Score: {goals.GetScore()}");
                    break;
                case "5":
                    goals.SaveGoals("goals.txt");
                    Console.WriteLine("Goals saved.");
                    break;
                case "6":
                    goals.LoadGoals("goals.txt");
                    Console.WriteLine("Goals loaded.");
                    break;
                case "7":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }
    }

    static void AddNewGoal(GoalCollection goals)
    {
        Console.WriteLine("\n--- Add New Goal ---");
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter goal points: ");
        int points = int.Parse(Console.ReadLine());

        Console.WriteLine("Select goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Select an option: ");
        string goalType = Console.ReadLine();

        Goal goal = goalType switch
        {
            "1" => new SimpleGoal(description, points, 0),
            "2" => new EternalGoal(description, points, 0),
            "3" => CreateChecklistGoal(description, points),
            _ => throw new ArgumentException("Invalid goal type")
        };

        goals.AddGoal(goal);
        Console.WriteLine("Goal added.");
    }

    static Goal CreateChecklistGoal(string description, int points)
    {
        Console.Write("Enter target completions: ");
        int targetCompletion = int.Parse(Console.ReadLine());
        Console.Write("Enter bonus points: ");
        int bonusPoints = int.Parse(Console.ReadLine());

        return new ChecklistGoal(description, points, 0, targetCompletion, bonusPoints);
    }

    static void RecordEvent(GoalCollection goals)
    {
        Console.WriteLine("\n--- Record an Event ---");
        goals.PrintGoals();
        Console.Write("Enter goal number to record event: ");
        int index = int.Parse(Console.ReadLine());

        goals.CompleteGoal(index - 1);
        Console.WriteLine("Event recorded.");
    }
}
