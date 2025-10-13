using System;

public class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    protected override void ExecuteActivity()
    {
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        
        Console.WriteLine("Starting breathing exercise...");
        
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in... ");
            ShowCountdown(4);
            
            if (DateTime.Now >= endTime) break;
            
            Console.WriteLine("Breathe out... ");
            ShowCountdown(6);
        }
    }
}