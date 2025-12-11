public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name,description,points)
    {
        SetName(name);
        SetDescription(description);
        SetPoints(points);
    }

    public override void RecordEvent()
    {
        SetIsComplete(true);
        
    }

    public override bool IsComplete()
    {
        return GetIsComplete();
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{GetName()},{GetDescription()},{GetPoints()},{_isComplete}";
    }

    public bool GetIsComplete()
    {
        return _isComplete;
    }

    public void SetIsComplete(bool isComplete)
    {
        _isComplete = isComplete;
    }
}