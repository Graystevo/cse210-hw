using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> entries = new List<Entry>();
    private string fileName;

    public void AddEntry(Entry entry)
    {
        // Directly save to the file instead of a list.
        File.AppendAllText(fileName, $"{entry.Date}~|~{entry.Prompt}~|~{entry.Response}\n");
    }

    public void DisplayJournal()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine(entry.ToString());
        }
    }

    public void SaveJournalToFile(string fileName)
    {
        this.fileName = fileName;
        foreach (var entry in entries)
        {
            AddEntry(entry);
        }
    }

    public void LoadJournalFromFile(string fileName)
    {
        this.fileName = fileName;
        entries.Clear(); // Clear current entries
        if (File.Exists(fileName))
        {
            foreach (var line in File.ReadLines(fileName))
            {
                var parts = line.Split(new[] { "~|~" }, StringSplitOptions.None);
                if (parts.Length == 3)
                {
                    var entry = new Entry(parts[1], parts[2]) { Date = parts[0] };
                    entries.Add(entry);
                }
            }
        }
    }
}
