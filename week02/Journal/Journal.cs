using System.IO;

public class Journal
{
    public List<Entry> _entries; // List of entries

    
    public Journal() // Constructor
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry newEntry) // Method to add an entry to the journal
    {
        _entries.Add(newEntry); // Add the new entry to the list of entries
    }

    public void DisplayAll() // Display all entries in the journal
    {
        foreach (Entry entry in _entries) // iterate the entries till the moment
        {
            entry.Display();
            Console.WriteLine();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
            
        }
        Console.WriteLine($"Entry saved to {file}");
    }

    public void LoadFromFile(string file)
    {
        foreach (string line in File.ReadLines(file))
        {
            string[] parts = line.Split('|');
            _entries.Add(new Entry(parts[0], parts[1], parts[2]));
        }
        Console.WriteLine($"Entries loaded from {file}");
            
    }
}