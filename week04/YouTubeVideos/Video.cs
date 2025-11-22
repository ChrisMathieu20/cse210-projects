public class Video
{
    private string _title;
    private string _author;
    private int _length;

    private List<Comment> _comments = new List<Comment>();

    public void DisplayVideo()
    {
        _title = GetTitle();
        _author = GetAuthor();
        _length = GetLength();
        Console.WriteLine("Youtube Video Program");
        Console.WriteLine("/////////////////////////////////////////////////");
        Console.WriteLine($"Titre: {_title}\nAuthor: {_author}\nLength: {_length} seconds");
        Console.WriteLine("Comments:");
        foreach (Comment c in _comments)
        {
            c.DisplayComment();
        }
        Console.WriteLine("/////////////////////////////////////////////////");
    }

    public string GetTitle()
    {
        return _title;
    }

    public void SetTitle(string title)
    {
        _title = title;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public void SetAuthor(string author)
    {
        _author = author;
    }

    public int GetLength()
    {
        return _length;
    }

    public void SetLength(int length)
    {
        _length = length;
    }

    public void AddComment(Comment newComment)
    {
        _comments.Add(newComment);
    }

    // public void GetComment()
    // {
    //     foreach (Comment c in _comments)
    //     {
    //         c.DisplayComment();
    //     }
    // }
}