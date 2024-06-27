using System;

class SimpleGoal : Goal
{
    private bool isComplete;

    public SimpleGoal(string description, int points, int timesCompleted)
        : base(description, points, timesCompleted)
    {
        isComplete = false;
    }

    public override void PrintGoal()
    {
        string status = isComplete ? "[X]" : "[ ]";
        Console.WriteLine($"{status} Simple Goal: {Description}, Points: {Points}");
    }

    public override void RecordEvent()
    {
        if (!isComplete)
        {
            TimesCompleted++;
            isComplete = true;
        }
    }

    public override bool IsComplete()
    {
        return isComplete;
    }
}
