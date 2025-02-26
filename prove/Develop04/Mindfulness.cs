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
        public void WaitAnimation()
        {
            Console.Write("Waiting ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(".");
                Thread.Sleep(500);
            }
            Console.WriteLine();
        }

        // Displays a generic ending message summarizing the activity.
        public void GenericEnding()
        {
            Console.WriteLine();
            Console.WriteLine("Well done!");
            WaitAnimation();
            Console.WriteLine($"You have completed another {_duration} of the {_activityName} Activity!");
            WaitAnimation();
        }

        // Displays a prompt chosen randomly from a list.
        public void DisplayPrompt(List<string> prompts)
        {
            if (prompts.Count > 0)
            {
                Random rand = new Random();
                int index = rand.Next(prompts.Count);
                Console.WriteLine(prompts[index]);
            }
        }
    }
}
