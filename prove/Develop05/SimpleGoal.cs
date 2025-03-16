using System;

public class SimpleGoal : Goal 
{
    private bool isCompleted;

    public SimpleGoal(string name, string description, int points) : base(name, description, points) 
    {
        isCompleted = false;
    }
    public SimpleGoal(string name, string description, int points, bool isCompleted) : base(name, description, points) 
    {
        this.isCompleted = isCompleted;
    }

    public override int RecordEvent() 
    {
        if (!isCompleted) 
        {
            isCompleted = true;
            return points;
        } 
        else 
        {
            Console.WriteLine("This goal has already been completed.");
            return 0;
        }
    }

    public override string GetDisplayString() 
    {
        string status = isCompleted ? "[X]" : "[ ]";
        return $"{status} {name} ({description})";
    }

    public override string GetSaveData() 
    {
        return $"SimpleGoal|{name}|{description}|{points}|{isCompleted}";
    }
}
