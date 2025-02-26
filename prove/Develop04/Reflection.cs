using System;
using System.Collections.Generic;
using System.Threading;

namespace MindfulnessApp
{
    public class Reflection : Mindfulness
    {
        // Activity-specific attributes.
        private List<string> _reflectPrompts;
        private List<string> _reflectQuestions;

        // Constructor: Initializes base values and reflection-specific lists.
        public Reflection() : base("Reflection", "This activity will help you reflect on times when you have shown strength and resilience. Reflect on your past experiences.")
        {
            _reflectPrompts = new List<string>
            {
                "Think of a time when you stood up for someone else.",
                "Think of a time when you did something really difficult.",
                "Think of a time when you helped someone in need.",
                "Think of a time when you did something truly selfless."
            };

            _reflectQuestions = new List<string>
            {
                "Why was this experience meaningful to you?",
                "Have you ever done anything like this before?",
                "How did you get started?",
                "How did you feel when it was complete?",
                "What made this time different than other times?",
                "What is your favorite thing about this experience?",
                "What could you learn from this experience?",
                "What did you learn about yourself through this experience?",
                "How can you keep this experience in mind in the future?"
            };
        }

        // Controls the sequence of the reflection activity.
        public void ReflectionMethod()
        {
            GenericGreeting();
            DurationPrompt();
            ReflectionDescription();
            Console.WriteLine("Get ready to begin...");
            WaitAnimation();

            // Display a random reflective prompt.
            DisplayPrompt(_reflectPrompts);

            // Continue to display reflection questions until the duration expires.
            DateTime startTime = DateTime.Now;
            while ((DateTime.Now - startTime).TotalSeconds < _duration)
            {
                ReflectionQuestion();
            }

            GenericEnding();
        }

        // Displays the description specific to the reflection activity.
        public void ReflectionDescription()
        {
            Console.WriteLine("Reflect on the following prompt and answer the questions that follow.");
        }

        // Iterates through reflective questions, pausing after each.
        public void ReflectionQuestion()
        {
            Random rand = new Random();
            int index = rand.Next(_reflectQuestions.Count);
            Console.WriteLine(_reflectQuestions[index]);
            WaitAnimation();
        }
    }
}
