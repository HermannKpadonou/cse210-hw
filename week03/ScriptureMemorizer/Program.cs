using System;

class Program
{
    static void Main(string[] args)
{
    Reference reference = new Reference("John", 3, 16);
    string text = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";
    Scripture scripture = new Scripture(reference, text);

    // Difficulty level selection
    DifficultyLevel difficulty = ChooseDifficulty();
    scripture.SetDifficulty(difficulty);

    Console.WriteLine($"Difficulty Level: {scripture.GetDifficultyDescription()}");
    Console.WriteLine("Press Enter to begin...");
    Console.ReadLine();

    string userInput = "";

    while (userInput.ToLower() != "quit" && !scripture.IsCompletelyHidden())
    {
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine($"\nLevel: {scripture.GetDifficultyDescription()}");
        Console.WriteLine("Press Enter to hide words or type 'quit' to exit.");
        Console.WriteLine("Type 'change' to change difficulty level.");
        
        userInput = Console.ReadLine();

        if (userInput.ToLower() == "quit")
            break;
            
        if (userInput.ToLower() == "change")
        {
            DifficultyLevel newDifficulty = ChooseDifficulty();
            scripture.SetDifficulty(newDifficulty);
            Console.WriteLine($"Level changed: {scripture.GetDifficultyDescription()}");
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }
        else
        {
            scripture.HideRandomWords(); // Uses the appropriate word count for difficulty
        }
    }

    Console.Clear();
    Console.WriteLine(scripture.GetDisplayText());
    
    if (scripture.IsCompletelyHidden())
    {
        Console.WriteLine("✅ All words are hidden! Congratulations!");
    }
    else
    {
        Console.WriteLine("👋 Goodbye! See you next time for more memorization!");
    }
    Console.ReadLine();
}

static DifficultyLevel ChooseDifficulty()
{
    Console.Clear();
    Console.WriteLine("🎯 CHOOSE YOUR DIFFICULTY LEVEL");
    Console.WriteLine("===============================");
    Console.WriteLine("1 - Easy (1-2 words hidden each time)");
    Console.WriteLine("2 - Medium (3 words hidden - Default)");
    Console.WriteLine("3 - Hard (4-5 words hidden)");
    Console.WriteLine("4 - Expert (6-8 words hidden)");
    Console.Write("Your choice (1-4): ");
    
    string choice = Console.ReadLine();
    
    return choice switch
    {
        "1" => DifficultyLevel.Easy,
        "2" => DifficultyLevel.Medium,
        "3" => DifficultyLevel.Hard,
        "4" => DifficultyLevel.Expert,
        _ => DifficultyLevel.Medium
    };
}
}