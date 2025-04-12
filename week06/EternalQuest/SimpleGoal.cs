using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal (string name, string description, int points, bool isComplete) 
        : base(name, description, points)
    {
        
        _isComplete = isComplete;
    }

    public override void RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            Console.WriteLine($"Congratulations! You earned {GetPoints()} points.");
        }
        else
        {
            Console.WriteLine("This goal has already been completed.");
        }
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }


    public override string GetDetailsString()
    {
        string status;

        if (_isComplete)
        {
            status = "[X]";
        }
        else
        {
            status = "[ ]";
        }
        return $"{status} {GetShortName()} ({GetDescription()})";
    }

    public override string GetStringRepresentation()
     {
        return $"SimpleGoal|{GetShortName()}|{GetDescription()}|{GetPoints()}|{_isComplete}";
     }

     
}