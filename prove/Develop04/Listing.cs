using System;
using System.Collections.Generic;
using System.Threading;

namespace MindfulnessApp
{
    public class Listing : Mindfulness
    {
        // Activity-specific attributes.
        private List<string> _listingPrompts;
        private List<string> _userResponses;

        // Constructor: Initializes base values and listing-specific lists.
        public Listing() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
        {
            _listingPrompts = new List<string>
            {
                "Who are people that you appreciate?",
                "What are personal strengths of yours?",
                "Who are people that you have helped this week?",
                "When have you felt the Holy Ghost this month?",
                "Who are some of your personal heroes?"
            };
            _userResponses = new List<string>();
        }

        // Manages the overall listing activity.
        public void ListingMethod()
        {
            GenericGreeting();
            DurationPrompt();
            Console.Clear();
            Console.WriteLine("Get ready to begin...");

            ListingDescription();
            WaitAnimation(5);

            DisplayPrompt(_listingPrompts);
            Console.WriteLine("You may begin in: ");
            for (int i = 5; i > 0; i--)
            {
                Console.Write($"{i} ");
                Thread.Sleep(1000);
            }
            Console.WriteLine();

            DateTime startTime = DateTime.Now;
            while ((DateTime.Now - startTime).TotalSeconds < _duration)
            {

                // Check if user has input a response.
                if (Console.KeyAvailable)
                {
                    Console.Write("> ");
                    string response = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(response))
                    {
                        _userResponses.Add(response);
                    }
                }
            }

            ResponseCount();
            GenericEnding();
        }

        // Explains the purpose of the listing activity.
        public void ListingDescription()
        {
            Console.WriteLine("List as many responses you can to the following prompt:");
        }

        // Displays the number of items the user has listed.
        public void ResponseCount()
        {
            Console.WriteLine($"You listed {_userResponses.Count} items.");
        }
    }
}
