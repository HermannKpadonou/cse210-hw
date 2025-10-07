using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Alice Carson", "Math");
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("Bertin Agbodjovi", "Physics", "Section 7.3", "1-10");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Merveille Mutombo", "English", "The Great changes in History");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}