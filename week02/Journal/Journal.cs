public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                string date = entry._date;
                string promptText = entry._promptText;
                string entryText = entry._entryText;
                outputFile.WriteLine($"{date}|{promptText}|{entryText}");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            string loadDate = parts[0];
            string loadPrompt = parts[1];
            string loadEntry = parts[2];
            Console.WriteLine($"Date: {loadDate} - Prompt: {loadPrompt}\n{loadEntry}\n");
        }
    }
}