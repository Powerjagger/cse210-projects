using System;

class ChecklistGoal : Goal
{
    public int TargetCompletion { get; set; }
    public int BonusPoints { get; set; }

    public ChecklistGoal(string description, int points, int timesCompleted, int targetCompletion, int bonusPoints)
        : base(description, points, timesCompleted)
    {
        TargetCompletion = targetCompletion;
        BonusPoints = bonusPoints;
    }

    public override void PrintGoal()
    {
        string status = TimesCompleted >= TargetCompletion ? "[X]" : "[ ]";
        Console.WriteLine($"{status} Checklist Goal: {Description}, Points: {Points}, Times Completed: {TimesCompleted}/{TargetCompletion}");
    }

    public override void RecordEvent()
    {
        if (TimesCompleted < TargetCompletion)
        {
            TimesCompleted++;
            if (TimesCompleted == TargetCompletion)
            {
                Console.WriteLine($"Bonus! You have completed the checklist goal and earned an additional {BonusPoints} points!");
            }
        }
    }

    public override bool IsComplete()
    {
        return TimesCompleted >= TargetCompletion;
    }
}
