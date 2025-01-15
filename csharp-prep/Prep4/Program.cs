using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

class Program
{

    static void Main(string[] args)
    {
        // user number list program
        List<int> numbers = new List<int>();

        int listNum = -1;

        do // Ask the user for a series of numbers, and append each one to a list.
        { 
            Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
            Console.Write("Enter number: ");
            listNum = int.Parse(Console.ReadLine());
            if (listNum != 0)
            {
                numbers.Add(listNum);
            }
        } while (listNum != 0);  // Stop when they enter 0.

        // Compute the sum, or total, of the numbers in the list.
        int totalSum = 0;
        foreach (int number in numbers)
        {
            totalSum = totalSum + number;
        }

        // Compute the average of the numbers in the list.
        // Find the maximum, or largest, number in the list.
    }
}