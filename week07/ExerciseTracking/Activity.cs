public abstract class Activity
{
    private string _date;
    private int _minutes;

    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public string GetDate() => _date;
    public int GetMinutes() => _minutes;

    // Polymorphic methods to override
    public abstract double GetDistance();  // miles or km
    public abstract double GetSpeed();     // mph or kph
    public abstract double GetPace();      // minutes per mile or km

    public virtual string GetSummary()
    {
        return $"{_date} {this.GetType().Name} ({_minutes} min) - " +
               $"Distance {GetDistance():0.0}, Speed {GetSpeed():0.0}, Pace {GetPace():0.0}";
    }
}
