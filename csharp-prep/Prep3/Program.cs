using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain;
        int userGuess = 0;

        do
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1,101);

            userGuess = -1;
            int guessCount = 0;
            while(userGuess != magicNumber)
            {
                guessCount++;
                Console.Write("Please guess the magic number: ");
                userGuess = int.Parse(Console.ReadLine());

                if (userGuess == magicNumber)
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took you {guessCount} guesses.");
                }
                else if (userGuess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (userGuess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
            }
            Console.Write("Would you like to play again? ");
            playAgain = Console.ReadLine();
        } while (playAgain == "yes");
    }
}