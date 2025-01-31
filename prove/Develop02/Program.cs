using System;

class Program
{
    static void Main(string[] args)
    {
        var journal = new Journal();
        var promptGenerator = new PromptGenerator();

        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Journal Menu");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    WriteNewEntry(journal, promptGenerator);
                    break;
                case "2":
                    journal.DisplayJournal();
                    break;
                case "3":
                    SaveJournal(journal);
                    break;
                case "4":
                    LoadJournal(journal);
                    break;
                case "5":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }

    static void WriteNewEntry(Journal journal, PromptGenerator promptGenerator)
    {
        string prompt = promptGenerator.GetRandomPrompt();
        Console.WriteLine($"Prompt: {prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();

        var entry = new Entry(prompt, response);
        journal.AddEntry(entry);
        Console.WriteLine("Entry saved!");
    }

    static void SaveJournal(Journal journal)
    {
        Console.Write("Enter filename to save the journal: ");
        string fileName = Console.ReadLine();
        journal.SaveJournalToFile(fileName);
        Console.WriteLine("Journal saved!");
    }

    static void LoadJournal(Journal journal)
    {
        Console.Write("Enter filename to load the journal: ");
        string fileName = Console.ReadLine();
        journal.LoadJournalFromFile(fileName);
        Console.WriteLine("Journal loaded!");
    }
}
