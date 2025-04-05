using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("breathing","This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", 0)
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in...");
            ShowCountDown(5);

            Console.Write("Now breathe out...");
            ShowCountDown(7);

            Console.WriteLine();
        }
    }
}


// How long, in seconds, would you like for your session?