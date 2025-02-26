using System;
using System.Collections.Generic;

namespace MindfulnessApp
{
    public class Menu
    {
        private List<string> _options;
        private bool _isRunning;

        // Constructor: Initializes menu options and sets the running flag.
        public Menu()
        {
            _options = new List<string> { "Breathing", "Reflection", "Listing", "Quit" };
            _isRunning = true;
        }

        // Displays the menu options.
        public void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("-------------------");
            for (int i = 0; i < _options.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_options[i]}");
            }
            Console.WriteLine("Select an option:");
        }

        // Gets and returns the user's menu selection.
        public int GetUserChoice()
        {
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > _options.Count)
            {
                Console.WriteLine("Invalid input. Please select a valid option:");
            }
            return choice;
        }

        // Main loop: Displays the menu, gets the user's selection, and runs the corresponding activity.
        public void RunSelection()
        {
            while (_isRunning)
            {
                DisplayMenu();
                int choice = GetUserChoice();
                switch (choice)
                {
                    case 1:
                        {
                            Breathing breathing = new Breathing();
                            breathing.BreathingMethod();
                            break;
                        }
                    case 2:
                        {
                            Reflection reflection = new Reflection();
                            reflection.ReflectionMethod();
                            break;
                        }
                    case 3:
                        {
                            Listing listing = new Listing();
                            listing.ListingMethod();
                            break;
                        }
                    case 4:
                        {
                            _isRunning = false;
                            Console.WriteLine("Thank you for using the Mindfulness Program. Goodbye!");
                            break;
                        }
                }
                if (_isRunning)
                {
                    Console.WriteLine("Press any key to return to the menu...");
                    Console.ReadKey();
                }
            }
        }
    }
}
