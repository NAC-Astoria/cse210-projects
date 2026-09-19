using System;

class Program
{
    static void Main(string[] args)
    {
        string letter = "";

        Console.Write("What is your grade percentage? ");
        string userGrade = Console.ReadLine();
        int grade = int.Parse(userGrade);

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";        
        }
        else if (grade >= 70)
        {
            letter = "C";        
        }
        else if (grade >= 60)
        {
            letter = "D";        
        }
        else
        {
            letter = "F";        
        }

        Console.WriteLine($"You have a {letter}");


        if (grade >= 70)
        {
            Console.WriteLine("Great job! You are passing the class.");
        }
        else
        {
            Console.WriteLine("Sorry, you are not passing the class. Better luck next time.");
        }

    }
}