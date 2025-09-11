using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> numbers = new List<int>();


        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        Console.Write("Enter number:");
        string input = Console.ReadLine();

        while (input != "0")
        {
            int number = int.Parse(input);
            numbers.Add(number);
            Console.Write("Enter number:");
            input = Console.ReadLine();
            
        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        float average = (float)sum / numbers.Count;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max is: {max}");
    }
}