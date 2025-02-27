using System;
using System.Collections.Generic;
using System.Threading;

namespace MindfulnessApp
{
    public class Mindfulness
    {
        // protected members accessible by child classes
        protected string _activityName;
        protected string _description;
        protected int _duration;

        public Mindfulness(string activityName, string description)
        {
            _activityName = activityName;
            _description = description;
        }

        // Displays a generic greeting that includes the activity name and description.
        public void GenericGreeting()
        {
            Console.Clear();
            Console.WriteLine($"Welcome to the {_activityName} Activity.");
            Console.WriteLine();
            Console.WriteLine(_description);
            Console.WriteLine();
        }

        // Prompts the user to input the duration (in seconds) for the session.
        public void DurationPrompt()
        {
            Console.Write("How long, in seconds, would you like for your session? ");
            while (!int.TryParse(Console.ReadLine(), out _duration))
            {
                Console.Write("Invalid input. Please enter a number: ");
            }
        }

        // Shows an animation during pauses (a simple dot progression in this case).
        public void WaitAnimation(int totalSeconds)
        {
            // Spinner characters for the animation.
            char[] spinner = { '|', '/', '-', '\\' };
            Console.Write("");

            DateTime startTime = DateTime.Now;
            int spinnerIndex = 0;
            // Continue looping until the specified duration has elapsed.
            while ((DateTime.Now - startTime).TotalSeconds < totalSeconds)
            {
                Console.Write(spinner[spinnerIndex]);
                Thread.Sleep(500);  // Delay for each spinner symbol.
                Console.Write("\b \b"); // Erase the symbol.
                spinnerIndex = (spinnerIndex + 1) % spinner.Length;
            }
        }

        // Displays a generic ending message summarizing the activity.
        public void GenericEnding()
        {
            Console.WriteLine();
            Console.WriteLine("Well done!");
            WaitAnimation(5);
            Console.WriteLine($"You have completed another {_duration} seconds of the {_activityName} Activity!");
            WaitAnimation(10);
        }

        // Displays a prompt chosen randomly from a list.
        public void DisplayPrompt(List<string> prompts)
        {
            if (prompts.Count > 0)
            {
                Random rand = new Random();
                int index = rand.Next(prompts.Count);
                Console.WriteLine($"--- {prompts[index]} ---");
            }
        }
    }
}
