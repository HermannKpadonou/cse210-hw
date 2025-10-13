using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        MindfulnessProgram program = new MindfulnessProgram();
        program.Run();
    }
}

public class MindfulnessProgram
{
    public void Run()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== MINDFULNESS PROGRAM ===");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Choose an activity: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.Start();
                    break;
                case "2":
                    ReflectingActivity reflection = new ReflectingActivity();
                    reflection.Start();
                    break;
                case "3":
                    ListingActivity listing = new ListingActivity();
                    listing.Start();
                    break;
                case "4":
                    Console.WriteLine("Thank you for using the Mindfulness Program!");
                    Thread.Sleep(2000);
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    Thread.Sleep(2000);
                    break;
            }
        }
    }
}