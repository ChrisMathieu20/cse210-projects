public abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        return $"{GetName()} ({GetDescription()})";
    }

    public abstract string GetStringRepresentation();

    public void SetName(string name)
    {
        _shortName = name;
    }

    public string GetName()
    {
        return _shortName;
    }

    public void SetDescription(string desc)
    {
        _description = desc;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetPoints(int points)
    {
        _points = points;
    }

    public int GetPoints()
    {
        return _points;
    }
}