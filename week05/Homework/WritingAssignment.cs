public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string name, string topic, string title) : base(name, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        _title = GetTitle();
        return $"{_title} by {GetStudentName()}";
    }

    public string GetTitle()
    {
        return _title;
    }
}