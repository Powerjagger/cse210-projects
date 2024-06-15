using System;
using System.Threading;

public class ReflectActivity : Activity
{
    private string[] questions = new string[]
    {
        "What are you grateful for today?",
        "What was a challenging moment you faced recently?",
        "How did you overcome a difficult situation?",
        "What are your goals for the next week?",
        "Who has positively impacted your life recently?"
    };

    public ReflectActivity(string titleParam, string descParam)
        : base(titleParam, descParam)
    {
    }

    public override void Start()
    {
        SetDuration();
        Console.WriteLine($"Starting {_title} activity...");
        Console.WriteLine(_desc);
        Console.WriteLine("Reflecting on your emotions and thoughts...");

        int questionIndex = 0;
        while (_duration > 0)
        {
            Console.WriteLine($"\n{questions[questionIndex]}");
            questionIndex = (questionIndex + 1) % questions.Length;

            for (int i = _duration; i > 0; i--)
            {
                Console.Write($"\rTime remaining: {i,-2} seconds   ");
                Thread.Sleep(1000);
                _duration--;
            }
        }

        Console.WriteLine("\nActivity ended.");
    }
}
