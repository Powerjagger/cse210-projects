using System;
using System.Threading;

public abstract class Activity
{
    protected int _duration;
    protected string _title;
    protected string _desc;

    public Activity(string titleParam, string descParam)
    {
        _title = titleParam;
        _desc = descParam;
    }

    public virtual void Start()
    {
        SetDuration();
        Console.WriteLine($"Starting {_title} activity...");
        Console.WriteLine(_desc);

        RunTimer();

        Console.WriteLine("\nActivity ended.");
    }

    protected void SetDuration()
    {
        Console.WriteLine("Enter the duration in seconds for the activity:");
        if (int.TryParse(Console.ReadLine(), out int duration))
        {
            _duration = duration;
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number of seconds.");
            SetDuration();
        }
    }

    protected virtual void RunTimer()
    {
        Console.WriteLine($"Activity will run for {_duration} seconds.");

        for (int i = _duration; i > 0; i--)
        {
            Console.Write($"\rTime remaining: {i,-2} seconds   ");
            Thread.Sleep(1000);
        }
    }
}
