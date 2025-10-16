using System;
using System.Collections.Generic;
using ExerciseTracking;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exercise Tracking Program");
        Console.WriteLine("==========================================================");

        
        List<Activity> activities = new List<Activity>();

        
        activities.Add(new Running(new DateTime(2025, 10, 13), 30, 4.8f));
        activities.Add(new Cycling(new DateTime(2025, 10, 13), 30, 20.0f));
        activities.Add(new Swimming(new DateTime(2025, 10, 13), 30, 40));
        activities.Add(new Running(new DateTime(2025, 10, 14), 45, 7.2f));
        activities.Add(new Swimming(new DateTime(2025, 10, 15), 60, 80));

        
        foreach (Activity activity in activities)
        {
            activity.GetSummary();
            Console.WriteLine();
        }
    }
}