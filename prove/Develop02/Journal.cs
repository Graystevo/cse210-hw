using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries = new List<Entry>(); // swapped to list in memory instead of temp file cache on disk

    public void AddEntry(string prompt, string response)
    {
        _entries.Add(new Entry(prompt, response));
    }

    public void DisplayEntries()
    {
        if (_entries.Count == 0) // checks if entry list is empty
        {
            Console.WriteLine("No entries found.");
            return;
        }

        foreach (var entry in _entries) // loop and display each loop
        {
            Console.WriteLine(entry.GetEntryDetails());
        }
    }

    public void SaveToFile(string filename) // saves file line by line to filename
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine($"{entry._date}~|~{entry._prompt}~|~{entry._response}");
            }
        }
        Console.WriteLine("Journal saved successfully.");
    }

    public void LoadFromFile(string filename) // loads file
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        _entries.Clear();

        string[] _lines = File.ReadAllLines(filename);
        foreach (var _line in _lines)
        {
            string[] _parts = _line.Split("~|~"); // read like csv with breaks at the symbol combo shown
            if (_parts.Length == 3)
            {                          // part 1 = prompt, part 2 = response, part 0 = date
                Entry entry = new Entry(_parts[1], _parts[2]) { _date = _parts[0] };
                _entries.Add(entry);
            }
        }
        Console.WriteLine("Journal loaded successfully.");
    }
}
