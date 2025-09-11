using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your score: ");
        string input = Console.ReadLine();
        int num = int.Parse(input);
        string letter = "";

        if (num >= 90)
        {
            if (100 <= num && num >= 93)
            {
                letter = "A";
            }
            else if (num < 93 && num >= 90)
            {
                letter = "A-";
            }

        }

        else if (num >= 80)
        {
            if (num < 90 && num >= 87)
            {
                letter = "B+";
            }
            else if (num < 87 && num >= 83)
            {
                letter = "B";
            }
            else if (num < 83 && num >= 80)
            {
                letter = "B-";
            }

        }

        else if (num >= 70)
        {
            if (num < 80 && num >= 77)
            {
                letter = "C+";
            }
            else if (num < 77 && num >= 73)
            {
                letter = "C";
            }
            else if (num < 73 && num >= 70)
            {
                letter = "C-";
            }

        }

        else if (num >= 60)

        {
            if (num < 70 && num >= 67)
            {
                letter = "D+";
            }
            else if (num < 67 && num >= 63)
            {
                letter = "D";
            }
            else if (num < 63 && num >= 60)
            {
                letter = "D-";
            }

        }

        else
        {
            letter = "F";
        }
        Console.WriteLine($"Your letter grade is: {letter}.");

        if (num >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Unfortunately, you did not pass the course. Better luck next time!");
        }
    }
}