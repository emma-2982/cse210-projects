using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string shortName, string description, int points, bool isComplete = false)
        : base(shortName, description, points)
    {
        _isComplete = isComplete;
    }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            Console.WriteLine($"Congrats! You have completed the goal '{ShortName}' and earned {Points} points!");
            return Points;
        }
        else
        {
            Console.WriteLine($"Goal '{ShortName}' is already complete. No extra points awarded.");
            return 0;
        }
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        
        return $"SimpleGoal:{ShortName}|{Description}|{Points}|{_isComplete}";
    }
}
