using System;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>
    {
        "Who are people who have made difference in your life?",
        "What are personal strengths of yours?",
        "Who made you feel special today?",
        "When have you felt the Holy Ghost this month?",
        "What are some phrases you recall from your parents"
    };

    public ListingActivity()
        : base("Listing","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 0)
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        ShowSpinner(3);

        string prompt = GetRandomPrompt();

        Console.WriteLine($"\nList as many responses you can to the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine("You may begin in:");
        
        ShowCountDown(5);

        Console.Write("How long, in seconds, would you like for your session?");
        int duration = int.Parse(Console.ReadLine());

        List<string> items = GetListFromUser(duration);
        _count = items.Count;
        Console.WriteLine($"You listed {_count} items!");

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string prompt = _prompts[index];
        return prompt;

    }

    public List<string> GetListFromUser(int duration)
    {
        List<string> responses = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            responses.Add(input);
        }

        return responses;
    }
        
    
}