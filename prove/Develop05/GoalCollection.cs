using System;
using System.Collections.Generic;
using System.IO;

class GoalCollection
{
    private List<Goal> goals = new List<Goal>();
    private int score;

    public void LoadGoals(string path)
    {
        if (File.Exists(path))
        {
            var lines = File.ReadAllLines(path);
            foreach (var line in lines)
            {
                var parts = line.Split(',');

                string type = parts[0];
                string description = parts[1];
                int points = int.Parse(parts[2]);
                int timesCompleted = int.Parse(parts[3]);

                Goal goal = type switch
                {
                    "Simple" => new SimpleGoal(description, points, timesCompleted),
                    "Eternal" => new EternalGoal(description, points, timesCompleted),
                    "Checklist" => new ChecklistGoal(description, points, timesCompleted, int.Parse(parts[4]), int.Parse(parts[5])),
                    _ => throw new ArgumentException("Unknown goal type")
                };

                goals.Add(goal);
            }
        }
    }

    public void SaveGoals(string path)
    {
        using (var writer = new StreamWriter(path, false)) // 'false' to overwrite the file
        {
            foreach (var goal in goals)
            {
                string line = goal switch
                {
                    SimpleGoal sg => $"Simple,{sg.Description},{sg.Points},{sg.TimesCompleted}",
                    EternalGoal eg => $"Eternal,{eg.Description},{eg.Points},{eg.TimesCompleted}",
                    ChecklistGoal cg => $"Checklist,{cg.Description},{cg.Points},{cg.TimesCompleted},{cg.TargetCompletion},{cg.BonusPoints}",
                    _ => throw new ArgumentException("Unknown goal type")
                };
                writer.WriteLine(line);
            }
        }
    }

    public void PrintGoals()
    {
        foreach (var goal in goals)
        {
            goal.PrintGoal();
        }
    }

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void CompleteGoal(int index)
    {
        if (index >= 0 && index < goals.Count)
        {
            goals[index].RecordEvent();
            score += goals[index].Points;

            if (goals[index] is ChecklistGoal cg && cg.IsComplete())
            {
                score += cg.BonusPoints;
            }
        }
    }

    public int GetScore()
    {
        return score;
    }

    public void InitializeTasks()
    {
        AddGoal(new SimpleGoal("Run a marathon", 1000, 0));
        AddGoal(new EternalGoal("Read scriptures", 100, 0));
        AddGoal(new ChecklistGoal("Attend the temple", 50, 0, 10, 500));
    }
}
