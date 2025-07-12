public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void Add(Entry entry)
    {
        _entries.Add(entry);
    }

    public void Display()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No journal entries yet.\n");
        }
        else
        {
            foreach (Entry entry in _entries)
            {
                Console.WriteLine(entry.Display());
            }
        }
    }

    public void Save(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
            }
        }

        Console.WriteLine($"Journal saved to '{filename}'.\n");
    }

    public void Load(string filename)
    {
        _entries.Clear();

        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 3)
                {
                    Entry entry = new Entry(parts[1], parts[2]);
                    entry.Date = parts[0];
                    _entries.Add(entry);
                }
            }

            Console.WriteLine($"Journal loaded from '{filename}'.\n");
        }
        else
        {
            Console.WriteLine($"File '{filename}' not found.\n");
        }
    }
}
