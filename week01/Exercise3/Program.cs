using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Console.Write("What is the magic number ?");
        string input = Console.ReadLine();
        int magicNumber = int.Parse(input);
        Random randomgenerator = new Random();
        string playAgain = "yes";
        while (playAgain.ToLower() == "yes")
        {



            magicNumber = randomgenerator.Next(1, 101);
            int guessNumber = -1;
            int numberOfGuesses = 0;
            while (guessNumber != magicNumber)
            {
                Console.Write("What is your guess? ");
                string guessInput = Console.ReadLine();
                guessNumber = int.Parse(guessInput);
                numberOfGuesses = numberOfGuesses + 1;

                if (guessNumber < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guessNumber > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"You guessed it and you guessed it in {numberOfGuesses} guesses !");
                }
            }
            Console.WriteLine("Do you want to play again? (yes/no):");
            playAgain = Console.ReadLine();

        }

        Console.Write("Thank you for playing!");


    }
}