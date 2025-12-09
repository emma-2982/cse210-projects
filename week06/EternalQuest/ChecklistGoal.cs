using System;

public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;

    public ChecklistGoal(
        string shortName,
        string description,
        int points,
        int targetCount,
        int currentCount,
        int bonusPoints)
        : base(shortName, description, points)
    {
        _targetCount = targetCount;
        _currentCount = currentCount;
        _bonusPoints = bonusPoints;
    }

    public override int RecordEvent()
    {
        _currentCount++;

        int total = Points;
        if (_currentCount == _targetCount)
        {
            total += _bonusPoints;
            Console.WriteLine($"You completed the checklist goal '{ShortName}'!");
            Console.WriteLine($"You earned {Points} points plus a bonus of {_bonusPoints} points!");
        }
        else
        {
            Console.WriteLine($"Progress recorded for '{ShortName}'. ({_currentCount}/{_targetCount})");
            Console.WriteLine($"You earned {Points} points.");
        }

        return total;
    }

    public override bool IsComplete()
    {
        return _currentCount >= _targetCount;
    }

    public override string GetDetailsString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {ShortName} ({Description}) -- Completed {_currentCount}/{_targetCount}";
    }

    public override string GetStringRepresentation()
    {
        
        return $"ChecklistGoal:{ShortName}|{Description}|{Points}|{_targetCount}|{_currentCount}|{_bonusPoints}";
    }
}
