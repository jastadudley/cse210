using System.Runtime.InteropServices.Marshalling;

public class Journal
{
    public List<Entry> _entries;

    public void AddEntry(Entry newEntry)
    {
        if (_entries == null)
        {
            _entries = new List<Entry>();
        }
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        if (_entries != null && _entries.Count>0)
        {
            foreach (Entry entry in _entries)
            {
                entry.Display();
            }
        }
        else
        {
            Console.WriteLine("There are no journal entrys to show");
        }

    }

    public void SaveToFile(string file)
    {
        if (_entries == null || _entries.Count == 0)
        {
            Console.WriteLine("There are no journal entries to save.");
            return;
        }
        using (StreamWriter writer = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"{entry._date} | {entry._promptText} | {entry._entryText}");
            }
        Console.WriteLine("The journal prompt has been saved successfully!");
        }
    }

    public void LoadFromFile(string file)
    {
        if (!File.Exists(file))
        {
            Console.WriteLine("The file you entered was not found.");
            return;
        }

        _entries = new List<Entry>();

        string[] lines = File.ReadAllLines(file);
        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            if (parts.Length == 3)
            {
                Entry entry = new Entry(parts[0], parts[1], parts[2]);
                _entries.Add(entry);
            }
            
        }

        Console.WriteLine("Your entrys have loaded sucessfully!");
    }
}