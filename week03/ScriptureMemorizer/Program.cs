using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("John", 3, 16);
        string text = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";
        Scripture scripture = new Scripture(reference, text);
        
        string userInput = "";

        while (userInput.ToLower() != "quit" && !scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Press Enter to hide more words or type 'quit' to exit.");
            userInput = Console.ReadLine();

            if (userInput.ToLower() != "quit")
            {
                scripture.HideRandomWords(3);
            }
        }
        
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        
        if (scripture.IsCompletelyHidden())
        {
            Console.WriteLine("All words are hidden. Press Enter to exit.");
        }
        else
        {
            Console.WriteLine("You have quit the program. Goodbye!");
        }
        Console.ReadLine();
    }
}