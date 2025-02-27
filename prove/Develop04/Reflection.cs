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
        public Reflection() : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
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
            GenericGreeting(); // welcome...
            DurationPrompt(); // how long u wanna?
            Console.Clear();

            Console.WriteLine("Get ready ...");
            WaitAnimation(5);

            ReflectionDescription(); // teach user what to do in task; consider the following...
            Console.WriteLine();
            DisplayPrompt(_reflectPrompts); // Display random prompt.
            Console.WriteLine();
            Console.WriteLine("When you have something in mind, press enter to continue.");
            Console.WriteLine();
            Console.ReadKey(); // wait for key press

            Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
            Console.WriteLine("You may begin in: ");
            for (int i = 5; i > 0; i--)
                {
                    Console.Write($"{i} ");
                    Thread.Sleep(1000);
                }
            Console.WriteLine();
            Console.WriteLine();

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
            Console.WriteLine("Consider the following prompt: ");
        }

        // Iterates through reflective questions, pausing after each.
        public void ReflectionQuestion()
        {
            Random rand = new Random();
            int index = rand.Next(_reflectQuestions.Count);
            Console.WriteLine($"> {_reflectQuestions[index]}");
            WaitAnimation(10);
        }
    }
}
