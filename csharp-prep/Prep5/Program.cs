using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int squaredNumber = SquareNumber(number);
        
        int year;
        PromptUserBirthYear(out year);

        DispalyResult(name, squaredNumber, year);        
    }

    static void DisplayWelcome()
        {
            // Display welcome message
            Console.WriteLine("Welcome to the Program!");            
        }

    static string PromptUserName()
    {
        // Get user name
        Console.Write("What is your name? ");
        string userName = Console.ReadLine();

        return userName;
    }

    static int PromptUserNumber()
    {
        // Get user number
        Console.Write("What is your favorite number? ");
        int userNumber = int.Parse(Console.ReadLine());
        
        return userNumber;
    }

    static void PromptUserBirthYear(out int year)
    {
        // Get user birth year
        Console.Write("What year were you born? ");
        int userBirth = int.Parse(Console.ReadLine());
        year = userBirth;
    }

    static int SquareNumber(int number)
    {
        int numberSquared = number * number;
        return numberSquared;
    }

    static void DispalyResult(string name, int squaredNumber, int year)
    {
        int age = 2026 - year;
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
        Console.WriteLine($"{name}, you will turn {age} this year");
    }

    
}