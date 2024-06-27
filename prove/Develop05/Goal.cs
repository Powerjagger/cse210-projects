using System;

abstract class Goal
{
    public string Description { get; set; }
    public int Points { get; set; }
    public int TimesCompleted { get; set; }

    public Goal(string description, int points, int timesCompleted)
    {
        Description = description;
        Points = points;
        TimesCompleted = timesCompleted;
    }

    public abstract void PrintGoal();
    public abstract void RecordEvent();
    public abstract bool IsComplete();
}
