using System;
using System.Collections.Generic;

public class ListingActivity : MindfulnessActivity
{
    private readonly string[] _prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private int _itemCount = 0;

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    protected override void ExecuteActivity()
    {
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Length)];
        
        Console.WriteLine($"List as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
        
        Console.Write("You have several seconds to begin thinking... ");
        ShowCountdown(5);

        Console.WriteLine($"You now have {_duration} seconds to list as many items as you can!");
        Console.WriteLine("Press Enter after each item.");
        
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        _itemCount = 0;
        
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            
            if (!string.IsNullOrWhiteSpace(input))
            {
                _itemCount++;
            }
            
            if (DateTime.Now >= endTime)
            {
                Console.WriteLine("Time's up!");
                break;
            }
        }

        Console.WriteLine($"You listed {_itemCount} items!");
    }

    protected override void ShowEndingMessage()
    {
        Console.WriteLine("Good job!");
        Console.WriteLine($"You have completed the {_name} for {_duration} seconds and listed {_itemCount} items.");
        ShowSpinner(5);
    }
}