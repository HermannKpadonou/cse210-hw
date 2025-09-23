using System;

class Program
{
    static void Main(string[] args)
    {
        Fan myFan = new Fan();
        Console.WriteLine(myFan.GetStatus());
        myFan.TurnOn();
        Console.WriteLine(myFan.GetStatus());
        
    }
}