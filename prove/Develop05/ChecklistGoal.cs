using System;

public class ChecklistGoal : Goal 
{
    private int timesCompleted;
    private int targetCount;
    private int bonus;
    private bool isCompleted;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonus) : base(name, description, points) 
    {
        this.targetCount = targetCount;
        this.bonus = bonus;
        timesCompleted = 0;
        isCompleted = false;
    }

    // Constructor used when loading from file.
    public ChecklistGoal(string name, string description, int points, int targetCount, int bonus, int timesCompleted, bool isCompleted) : base(name, description, points) 
    {
        this.targetCount = targetCount;
        this.bonus = bonus;
        this.timesCompleted = timesCompleted;
        this.isCompleted = isCompleted;
    }

    public override int RecordEvent() 
    {
        if (!isCompleted) 
        {
            timesCompleted++;
            int totalPoints = points;
            if (timesCompleted >= targetCount && !isCompleted) 
            {
                totalPoints += bonus;
                isCompleted = true;
            }
            return totalPoints;
        } 
        else 
        {
            Console.WriteLine("This checklist goal has already been completed.");
            return 0;
        }
    }

    public override string GetDisplayString() 
    {
        string status = isCompleted ? "[X]" : "[ ]";
        return $"{status} {name} ({description}) -- Completed {timesCompleted}/{targetCount} times";
    }

    public override string GetSaveData() 
    {
        return $"ChecklistGoal|{name}|{description}|{points}|{timesCompleted}|{targetCount}|{bonus}|{isCompleted}";
    }
}
