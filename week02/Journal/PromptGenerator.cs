using System;
public class PromptGenerator
{
    public List<string> _prompts; 
    public Random _random; // Random object

    public PromptGenerator() 
    {
        _prompts = new List<string>
        {
            "What was the best part of your day?",
            "What new did you learn today?",
            "Describe a moment that made you smile or feel sad.",
            "What are you grateful for today, did you see God's hand?",
            "What challenge did you overcome today?",
            "Who made a difference in your day?",
            "What would you like your children to know about today?",
            "What is something new you tried today?",
            "What is something you would like to do differently tomorrow?",
            "What is something you would like to do again tomorrow?",
            "What would you tell your future you about today?"
        };
        _random = new Random();
    }

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}