using System;

public class EternalGoal : Goal
{
    private int timesCompleted;

    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        timesCompleted = 0;
    }

    public EternalGoal(string name, string description, int points, int timesCompleted) : base(name, description, points)
    {
        this.timesCompleted = timesCompleted;
    }

    public override int RecordEvent()
    {
        timesCompleted++;
        return points;
    }

    public override string GetDisplayString()
    {
        return $"[ ] {name} ({description}) -- Completed {timesCompleted} times";
    }

    public override string GetSaveData()
    {
        return $"EternalGoal|{name}|{description}|{points}|{timesCompleted}";
    }
}
