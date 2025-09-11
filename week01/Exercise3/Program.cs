using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Random random = new Random();
        int magicNumber = random.Next(1, 100);
        string input;

        Console.Write("What is your guess? ");
        input = Console.ReadLine();
        int guess = int.Parse(input);

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