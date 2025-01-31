using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> entries = new List<Entry>();
    private string responseLogFile = "responseLog.csv"; // File that logs all responses

    public Journal()
    {
        // Ensure the file exists; if not, create it with a header row.
        if (!File.Exists(responseLogFile))
        {
            File.WriteAllText(responseLogFile, "Date~|~Prompt~|~Response\n");
        }
    }

    public void AddEntry(string prompt, string response)
    {
        Entry newEntry = new Entry(prompt, response);
        entries.Add(newEntry);

        // Append the new entry to responseLog.csv using "~|~" as the delimiter
        using (StreamWriter writer = new StreamWriter(responseLogFile, true))
        {
            writer.WriteLine($"{newEntry.Date}~|~{EscapeText(prompt)}~|~{EscapeText(response)}");
        }
    }

    public void DisplayEntries()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("No entries found.");
            return;
        }

        foreach (var entry in entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile(string filename)
    {
        if (!File.Exists(responseLogFile))
        {
            Console.WriteLine("No entries to save.");
            return;
        }

        File.Copy(responseLogFile, filename, true); // Copies the response log to the new file
        Console.WriteLine($"Journal saved successfully to {filename}.");
    }

    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        entries.Clear();
        string[] lines = File.ReadAllLines(filename);
        foreach (var line in lines)
        {
            string[] parts = line.Split('|');
            if (parts.Length == 3)
            {
                Entry entry = new Entry(parts[1], parts[2]) { Date = parts[0] };
                entries.Add(entry);
            }
        }
        Console.WriteLine("Journal loaded successfully.");
    }

    // Helper method to escape "~|~" in user input
    private string EscapeText(string text)
    {
        return text.Replace("~|~", " "); // Prevents breaking the delimiter
    }
}
