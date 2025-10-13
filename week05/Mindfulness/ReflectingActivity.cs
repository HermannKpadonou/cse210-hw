using System;
using System.Collections.Generic;

public class ReflectingActivity : MindfulnessActivity
{
    private readonly string[] _prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private readonly string[] _questions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity()
    {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

    }
    
    private static Random random = new Random();



    protected override void ExecuteActivity()
    {
        string prompt = _prompts[random.Next(_prompts.Length)];
        
        Console.WriteLine($"Consider the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();
        
        Console.WriteLine("\nNow ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        ShowCountdown(5);
        
        Console.WriteLine();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        List<string> usedQuestions = new List<string>();

        while (DateTime.Now < endTime && usedQuestions.Count < _questions.Length)
        {
            string question;
            do
            {
                question = _questions[random.Next(_questions.Length)];
            } while (usedQuestions.Contains(question) && usedQuestions.Count < _questions.Length);
            
            usedQuestions.Add(question);
            
            Console.Write($"\n> {question} ");
            ShowSpinner(8);
            
            if (DateTime.Now >= endTime)
                break;
        }
    }
}