using System;

public class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, int points)
        : base(shortName, description, points)
    {
    }

    public override int RecordEvent()
    {
        Console.WriteLine($"You recorded progress on eternal goal '{ShortName}' and earned {Points} points!");
        return Points;
    }

    public override bool IsComplete()
    {
        
        return false;
    }

    public override string GetDetailsString()
    {
        
        return $"[∞] {ShortName} ({Description})";
    }

    public override string GetStringRepresentation()
    {
        
        return $"EternalGoal:{ShortName}|{Description}|{Points}";
    }
}
