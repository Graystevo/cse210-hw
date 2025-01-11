using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int gradePercent = int.Parse(userInput);
        string gradeLetter = "";
        bool passClass = false;

        if (gradePercent >= 90)
        {
            gradeLetter = "A";
            passClass = true;
        }
        else if (gradePercent >= 80)
        {
            gradeLetter = "B";
            passClass = true;
        }
        else if (gradePercent >= 70)
        {
            gradeLetter = "C";
            passClass = true;
        }
        else if (gradePercent >= 60)
        {
            gradeLetter = "D";
            passClass = false;
        }
        else
        {
            gradeLetter = "F";
            passClass = false;
        }

        Console.WriteLine($"You got {gradeLetter} as your final grade.");

        if (passClass == true)
        {
            Console.WriteLine("Good job on passing!");
        }
        else
        {
            Console.WriteLine("You suck.");
        }
    }
}