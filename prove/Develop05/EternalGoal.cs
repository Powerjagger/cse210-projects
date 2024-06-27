using System;

class EternalGoal : Goal
{
    public EternalGoal(string description, int points, int timesCompleted)
        : base(description, points, timesCompleted)
    {
    }

    public override void PrintGoal()
    {
        Console.WriteLine($"[ ] Eternal Goal: {Description}, Points: {Points}, Times Completed: {TimesCompleted}");
    }

    public override void RecordEvent()
    {
        TimesCompleted++;
    }

    public override bool IsComplete()
    {
        return false; // Eternal goals are never complete
    }
}
