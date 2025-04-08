using System;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you did something really difficult.",
        "Think of a time when you stood up for someone else.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless"
    };
    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity ()
        : base("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience.", 0)
    {
    }

    public void Run()
    {
        
        Console.Write("How long, in seconds, would you like for your session? ");
        int duration = int.Parse(Console.ReadLine());
        SetDuration(duration);

        DisplayStartingMessage();
        ShowSpinner(3);

        string prompt = GetRandomPrompt();
        Console.WriteLine($"\nConsider the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.WriteLine("You may begin in:");
        ShowCountDown(5);


        DisplayQuestions(duration);

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(_prompts.Count)];
    }
    public string GetRandomQuestion()
    {
        Random random = new Random();
        return _questions[random.Next(_questions.Count)];
    }

    public void DisplayQuestions(int duration)
    {
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        List<string> shuffledQuestions = new List<string>(_questions);
        Random random = new Random();

        for (int i = 0; i < shuffledQuestions.Count; i++)
        {
            int j = random.Next(i, shuffledQuestions.Count);
            string temp = shuffledQuestions[i];
            shuffledQuestions[i] = shuffledQuestions[j];
            shuffledQuestions[j] = temp;
        }

        int index = 0;
        while (DateTime.Now < endTime && index < shuffledQuestions.Count)
        {
            Console.WriteLine($">{shuffledQuestions[index]}");
            index++;
            ShowSpinner(4);
        }
    }
}