using System;

public abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points;

    public string ShortName => _shortName;
    public string Description => _description;
    public int Points => _points;

    public Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    // Polymorphic: each goal implements how it handles a recorded event
    public abstract int RecordEvent();

    
    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {ShortName} ({Description})";
    }

    
    public abstract string GetStringRepresentation();
}
