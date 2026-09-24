using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int newNumber = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Create number list from user input
        while (newNumber != 0)
        {
            Console.Write("Enter a number ");
            newNumber = int.Parse(Console.ReadLine());
            if (newNumber != 0)
            {
                numbers.Add(newNumber);
            }
        }

        // Calculate sum
        int total = 0;
        foreach (int number in numbers)
        {
            total += number;
        }
        Console.WriteLine($"The sum is: {total}");

        // Calculate average
        float average = ((float)total) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // Determine largest
        int largestNumber = 0;
        foreach (int number in numbers)
        {
            if (number > largestNumber)
            {
                largestNumber = number;
            }  
        }
        Console.WriteLine($"The largest number is: {largestNumber}");

        // Determine smallest positive number
        int smallestNumber = 999;
        foreach (int number in numbers)
        {
            if (number < smallestNumber && number > 0)
            {
                smallestNumber = number;
            }
        }
        Console.WriteLine($"The smallest positive number is {smallestNumber}");

        // Sort list
        numbers.Sort();
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

    }
}