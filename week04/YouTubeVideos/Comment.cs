public class Comment
{
    private string _name;
    private string _text;

    public void DisplayComment()
    {
        _name = GetName();
        _text = GetText();
        Console.WriteLine($"@~ {_name}\n> {_text}");
    }

    public string GetName()
    {
        return _name;    
    }

    public void SetName(string userName)
    {
        _name = userName;
    }

    public string GetText()
    {
        return _text;
    }

    public void SetText(string comment)
    {
        _text = comment;
    }
}