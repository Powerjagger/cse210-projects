using System;
using System.Threading;

public class ListActivity : Activity
{
    public ListActivity(string titleParam, string descParam)
        : base(titleParam, descParam)
    {
    }

    public override void Start()
    {
        SetDuration();
        Console.WriteLine($"Starting {_title} activity...");
        Console.WriteLine(_desc);
        Console.WriteLine("Listing positive things in your life...");

        while (_duration > 0)
        {
            Console.WriteLine("\nThink of and list as many positive things or areas of strength as you can...");

            for (int i = 0; i < 10 && _duration > 0; i++)
            {
                Console.Write($"\rTime remaining: {_duration} seconds   ");
                Thread.Sleep(1000);
                _duration--;
            }

            if (_duration > 0)
            {
                Console.WriteLine("\nKeep going, you're doing great!");
            }
        }

        Console.WriteLine("\nActivity ended. Well done!");
    }
}
