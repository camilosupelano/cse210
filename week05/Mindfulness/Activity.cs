using System;
public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity (string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }
    public int GetDuration()
    {
        return _duration;
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"\nWelcome to the {_name} Activity.");
        Console.WriteLine(_description);
        Console.WriteLine($"Relax for a moment, you will do this for {_duration} seconds. \n");
        ShowCountDown(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nDo you notice you feel better?");
        Console.WriteLine($"You have successfully completed the {_name} activity. \n");
        ShowSpinner(3);
    }

    public void ShowSpinner (int seconds)
    {
        string[] spinner = { "|", "/", "-","\\"};
        int totalSpins = seconds * 4;

        int i = 0;
        int count = 0;

        while (count < totalSpins)
        {
            Console.Write(spinner[i] + " \b\b");
            Thread.Sleep(250);
            Console.Write("\b \b");

            i++;
            count++;

            if (i ==  spinner.Length)
            {
                i = 0;
            }
        }
       Console.WriteLine();
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i>0; i--)
        {
            Console.Write($" {i}...");
            Thread.Sleep(1000);
            Console.Write("\b\b\b");
        }
        Console.WriteLine(" \b\b\b");
    }
}