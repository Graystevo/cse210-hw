public abstract class Goal 
{
    protected string name;
    protected string description;
    protected int points;

    public Goal(string name, string description, int points) 
    {
        this.name = name;
        this.description = description;
        this.points = points;
    }

    public abstract int RecordEvent();
    public abstract string GetDisplayString();
    public abstract string GetSaveData();
}
