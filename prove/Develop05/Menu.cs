using System;
using System.Collections.Generic;
using System.IO;

public class Menu
{
    private int score;
    private List<Goal> goals;

    public Menu()
    {
        score = 0;
        goals = new List<Goal>();
    }

    public void Run()
    {
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("\n--- Eternal Quest ---");
            Console.WriteLine($"Score: {score}");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    CreateNewGoal();
                    break;
                case "2":
                    ListGoals();
                    break;
                case "3":
                    RecordEvent();
                    break;
                case "4":
                    SaveGoals();
                    break;
                case "5":
                    LoadGoals();
                    break;
                case "6":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid option, try again.");
                    break;
            }
        }
    }

    private void CreateNewGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string typeChoice = Console.ReadLine();

        Console.Write("Enter the name of your goal: ");
        string name = Console.ReadLine();
        Console.Write("Enter a short description: ");
        string description = Console.ReadLine();
        Console.Write("Enter the points associated with this goal: ");
        int points = int.Parse(Console.ReadLine());

        Goal goal = null;
        switch (typeChoice)
        {
            case "1":
                goal = new SimpleGoal(name, description, points);
                break;
            case "2":
                goal = new EternalGoal(name, description, points);
                break;
            case "3":
                Console.Write("Enter the number of times this goal needs to be accomplished for a bonus: ");
                int targetCount = int.Parse(Console.ReadLine());
                Console.Write("Enter the bonus points for accomplishing the goal: ");
                int bonus = int.Parse(Console.ReadLine());
                goal = new ChecklistGoal(name, description, points, targetCount, bonus);
                break;
            default:
                Console.WriteLine("Invalid goal type selected.");
                return;
        }
        goals.Add(goal);
        Console.WriteLine("Goal created successfully!");
    }

    private void ListGoals()
    {
        Console.WriteLine("\nYour Goals:");
        int index = 1;
        foreach (Goal goal in goals)
        {
            Console.WriteLine($"{index}. {goal.GetDisplayString()}");
            index++;
        }
    }

    private void RecordEvent()
    {
        Console.WriteLine("Select the goal you accomplished:");
        int index = 1;
        foreach (Goal goal in goals)
        {
            Console.WriteLine($"{index}. {goal.GetDisplayString()}");
            index++;
        }
        Console.Write("Enter the number of the goal: ");
        int choice = int.Parse(Console.ReadLine());
        if (choice < 1 || choice > goals.Count)
        {
            Console.WriteLine("Invalid goal number.");
            return;
        }
        Goal selectedGoal = goals[choice - 1];
        int earnedPoints = selectedGoal.RecordEvent();
        score += earnedPoints;
        Console.WriteLine($"You earned {earnedPoints} points!");
    }

    private void SaveGoals()
    {
        Console.Write("Enter the filename to save: ");
        string filename = Console.ReadLine();
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(score);
            foreach (Goal goal in goals)
            {
                writer.WriteLine(goal.GetSaveData());
            }
        }
        Console.WriteLine("Goals saved successfully! WOOOOOOO");
    }

    private void LoadGoals()
    {
        Console.Write("Enter the filename to load: ");
        string filename = Console.ReadLine();
        if (!File.Exists(filename))
        {
            Console.WriteLine("File does not exist. Bummer");
            return;
        }
        goals.Clear();
        using (StreamReader reader = new StreamReader(filename))
        {
            string firstLine = reader.ReadLine();
            score = int.Parse(firstLine);
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split('|');
                string goalType = parts[0];
                Goal goal = null;
                switch (goalType)
                {
                    case "SimpleGoal":
                        // Format: SimpleGoal|name|description|points|isCompleted
                        goal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]));
                        break;
                    case "EternalGoal":
                        // Format: EternalGoal|name|description|points|timesCompleted
                        goal = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]));
                        break;
                    case "ChecklistGoal":
                        // Format: ChecklistGoal|name|description|points|timesCompleted|targetCount|bonus|isCompleted
                        goal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[5]), int.Parse(parts[6]), int.Parse(parts[4]), bool.Parse(parts[7]));
                        break;
                    default:
                        Console.WriteLine("Unknown goal type in file.");
                        break;
                }
                if (goal != null)
                {
                    goals.Add(goal);
                }
            }
        }
        Console.WriteLine("Goals loaded successfully!");
    }
}
