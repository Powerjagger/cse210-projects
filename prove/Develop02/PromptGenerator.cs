using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _promptList = new List<string>
    {
        "What was one thing you saw today",
        "How are you feeling about classes",
        "If you could live in a fantasy world, which one and why?",
        "What would your dream date be?",
        "What are your thoughts on the Roman Empire",
        "What is your favorite movie and why?",
        "What is your favorite video game and why?",
        "Why do you fight?",
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(0, _promptList.Count);
        return _promptList[index];
    }
}
