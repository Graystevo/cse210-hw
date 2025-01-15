using System;

class Program
{
    static void Main(string[] args)
    {
        // Magic Number program start
        // step 1: generate magic number 1-100
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        int userGuess = -100;
        int guessCount = 0;
        // step 4: ask user to play again when guess is correct. 
        string response;
        do
        {
            // step 2: ask user to guess 
            while (userGuess != magicNumber)
            {
                Console.Write("What is your guess? ");
                userGuess = int.Parse(Console.ReadLine());
                guessCount = guessCount + 1;
                // step 3: tell user higher or lower, track guess count
                if (magicNumber > userGuess)
                {
                    Console.WriteLine("Higher");
                }
                else if (magicNumber < userGuess)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"You guessed {guessCount} times!");
                }
            }
            // step 4: ask user to play again when guess is correct. 
            Console.Write("Do you want to continue? (yes/no)");
            response = Console.ReadLine();
        } while (response == "yes");
    }
}