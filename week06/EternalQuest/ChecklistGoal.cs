using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) 
        : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;

        int totalPoints = GetPoints();
        Console.WriteLine($"Congratulations! You earned {totalPoints} points.");

        if (_amountCompleted == _target)
        {
            Console.WriteLine($"You completed the goal and earned a bonus of {_bonus} points!");
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        string status;
        if (IsComplete())
        {
            status = "[X]";
        }
        else
        {
            status = "[ ]";
        }

        return $"{status} {GetShortName()} ({GetDescription()}) -- Completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{GetShortName()}|{GetDescription()}|{GetPoints()}|{_bonus}|{_target}|{_amountCompleted}";
    }
    public int GetBonus()
    {
        return _bonus;
    }
}