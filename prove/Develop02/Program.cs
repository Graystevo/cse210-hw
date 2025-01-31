using System;

class Program
{
    static void Main()
    {
        Journal journal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();

        while (true)
        {
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": // call for prompt, ask user to respond, send response and prmpt to Journal
                    string prompt = promptGen.GetRandomPrompt();
                    Console.WriteLine($"\nPrompt: {prompt}");
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();
                    journal.AddEntry(prompt, response);
                    break;

                case "2": // display list of entries
                    journal.DisplayEntries();
                    break;

                case "3": // save to file
                    Console.Write("Enter filename to save: ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    break;

                case "4": // load file
                    Console.Write("Enter filename to load: ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    break;

                case "5": // exit
                    Console.WriteLine("Goodbye!");
                    return;

                default: // wrong entry
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}
