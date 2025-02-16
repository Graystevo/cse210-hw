using System;

namespace ScriptureMemorizer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example: using a single verse reference.
            Reference reference = new Reference("John", 3, 16);
            string scriptureText = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";
            
            // For a scripture with multiple verses, you could use:
            // Reference reference = new Reference("Proverbs", 3, 5, 6);
            // string scriptureText = "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.";
            
            Scripture scripture = new Scripture(reference, scriptureText);

            while (true)
            {
                Console.Clear();
                scripture.Display();

                if (scripture.AllWordsHidden())
                {
                    Console.WriteLine("\nAll words are hidden. Good job!");
                    break;
                }

                Console.WriteLine("\nPress Enter to hide more words, or type 'quit' to exit.");
                string input = Console.ReadLine();

                if (input.Trim().ToLower() == "quit")
                {
                    break;
                }

                // Hide a few random words. For the core requirements, we allow already-hidden words.
                scripture.HideRandomWords(3);
            }
        }
    }
}
