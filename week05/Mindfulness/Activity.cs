using System;
using System.Threading;

public abstract class MindfulnessActivity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    
     private readonly List<string> _animationStrings = new List<string>
    {
        "|", "/", "-", "\\", "|", "/", "-", "\\"
    };
    
    private bool _spinnerRunning = false;

    public void Start()
    {
        ShowStartingMessage();
        Console.Write("Enter duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Prepare to begin...");
        ShowSpinner(5);
        
        ExecuteActivity();
        
        ShowEndingMessage();
    }

    protected virtual void ShowStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"=== {_name} ===");
        Console.WriteLine(_description);
        Console.WriteLine();
    }

    protected virtual void ShowEndingMessage()
    {
        Console.WriteLine("Good job!");
        Console.WriteLine($"You have completed the {_name} for {_duration} seconds.");
        ShowSpinner(5);
    }

    protected void ShowSpinner(int seconds)
    {
        _spinnerRunning = true;
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < endTime && _spinnerRunning)
        {
            string s = _animationStrings[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i >= _animationStrings.Count)
            {
                i = 0;
            }
        }
    }

    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"\r{i} ");
            Thread.Sleep(1000);
        }
        Console.Write("\r  \r");
    }

    protected abstract void ExecuteActivity();
}