using System;
using System.Collections.Generic;
using System.Threading;

namespace MindfulnessApp
{
    public class Breathing : Mindfulness
    {
        // Activity-specific attribute.
        private List<string> _breathingPattern;

        // Constructor: Initializes base values and sets up breathing-specific data. (name, desc)
        public Breathing() : base("Breathing", "This activity will help you relax by guiding you through deep breathing. Clear your mind and focus on your breathing.")
        {
            _breathingPattern = new List<string> { "Breathe in...", "Breathe out..." };
        }

        // Orchestrates the breathing activity.
        public void BreathingMethod()
        {
            GenericGreeting();
            DurationPrompt();
            BreathingDescription();
            Console.WriteLine("Get ready to begin...");
            WaitAnimation();

            int secondsElapsed = 0;
            while (secondsElapsed < _duration)
            {
                BreathInOut();
                // assume each cycle takes approximately 5 seconds.
                secondsElapsed += 5;
            }

            GenericEnding();
        }

        // Displays the description specific to the breathing activity.
        public void BreathingDescription()
        {
            Console.WriteLine("Follow the instructions to breathe in and out slowly.");
        }

        // Alternates between "Breathe in..." and "Breathe out..." with a simple countdown.
        public void BreathInOut()
        {
            foreach (string instruction in _breathingPattern)
            {
                Console.WriteLine(instruction);
                for (int i = 0; i < 5; i++)
                {
                    Console.Write($"{i} ");
                    Thread.Sleep(1000);
                }
                Console.WriteLine();
            }
        }
    }
}
