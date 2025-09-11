using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        string input;

        int guess = -1;

        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            input = Console.ReadLine();
            guess = int.Parse(input);
            if (guess < magicNumber)
            {
                Console.WriteLine("Lower!");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Higher!");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }

    }
}