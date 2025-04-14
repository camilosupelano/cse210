using System;

public abstract class Activity
{
    private string _date;
    private int _duration;

    public Activity(string date, int duration)
    {
        _date = date;
        _duration = duration;
    }


    protected string Date
    {
        get { return _date; }
        set { _date = value; }
    }
    protected int Duration
    {
        get { return _duration; }
        set { _duration = value; }
    }


    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public string GetSummary()
    {
        return $"{_date} {this.GetType().Name} ({_duration} min) - Distance: {GetDistance():0.0}, Speed: {GetSpeed():0.0}, Pace: {GetPace():0.0} min per mile";
    }
}