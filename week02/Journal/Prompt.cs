using System;

public class Prompt
{
    private List<string> _prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of your day?",
        "How did I see the hand of the Lord in my life today?",
        "What did you learn today?",
        "What are you grateful for?",
        "If I had one thing I could do over today, what would it be?"
    };

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }
}