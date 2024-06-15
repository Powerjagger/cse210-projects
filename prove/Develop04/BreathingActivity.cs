using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity(string titleParam, string descParam)
        : base(titleParam, descParam)
    {
    }

    protected override void RunTimer()
    {
        base.RunTimer();

        Console.WriteLine("\nBreathe deeply and relax...");
        Thread.Sleep(2000);
    }
}
