using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome(); // Displays the message, "Welcome to the Program!"

        string userName = PromptUserName(); // Asks for and returns the user's name (as a string)
        int userNumber = PromptUserNumber(); // Asks for and returns the user's favorite number (as an integer)
        int squaredNumber = SquareNumber(userNumber); // Accepts an integer as a parameter and returns that number squared (as an integer)

        DisplayResult(userName, squaredNumber);
    }

    static void DisplayWelcome() // Displays the message, "Welcome to the Program!"
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName() // Asks for and returns the user's name (as a string)
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine(); // returns user input as string
    }

    static int PromptUserNumber() // Asks for and returns the user's favorite number (as an integer)
    {
        Console.Write("Please enter your favorite number: ");
        int number;
        while (!int.TryParse(Console.ReadLine(), out number)) // check if actually integer
        {
            Console.Write("Invalid input. Please enter a valid integer: ");
        }
        return number;
    }

    static int SquareNumber(int number) // Accepts an integer as a parameter and returns that number squared (as an integer)
    {
        return number * number; // returns square of number.
    }

    static void DisplayResult(string userName, int squaredNumber)
    {
        Console.WriteLine($"{userName}, the square of your number is {squaredNumber}");
    }
}