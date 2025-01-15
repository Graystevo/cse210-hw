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
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");

        do // Ask the user for a series of numbers, and append each one to a list.
        {
            Console.Write("Enter number: ");
            listNum = int.Parse(Console.ReadLine());
            if (listNum != 0)
            {
                numbers.Add(listNum);
            }
        } while (listNum != 0);  // Stop when they enter 0.

        // Compute the sum of the numbers in the list. done
        int totalSum = 0;
        foreach (int number in numbers)
        {
            totalSum = totalSum + number;
        }
        Console.WriteLine($"The sum is: {totalSum}");

        // Compute the average of the numbers in the list.
        // int avg = totalSum / numbers.Count; // has No decimals whoops.
        float average = ((float)totalSum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // Find the maximum number in the list.
        // sort list then select last number
        numbers.Sort();
        Console.WriteLine($"The largest number is: {numbers[numbers.Count-1]}");
        
        // sorted list output
        Console.WriteLine("The sorted list is:");
        Console.WriteLine(string.Join(", ", numbers));
    }
}