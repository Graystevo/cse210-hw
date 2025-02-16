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

                Console.WriteLine("\nPress Enter to hide 3 words, type 'unhide' to unhide 3 random words, or type 'quit' to exit.");
                string input = Console.ReadLine().Trim().ToLower();

                if (input == "quit")
                {
                    break;
                }
                else if (input == "unhide") // unhides 3 random words, CHECKED to make sure it only unhides hidden words
                {
                    scripture.UnhideRandomWords(3);
                }
                else // Default action = hides 3 rand words, CHECKED to make sure it doesn't hide word already hidden
                {
                    scripture.HideRandomWords(3);
                }
            }
        }
    }
}
