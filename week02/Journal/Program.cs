using System;
using System.IO; 

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        
        bool running = true;
        
        while (running)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1": 
                    string promptText = promptGenerator.GetRandomPrompt();
                    Console.WriteLine(promptText);
                    string entryText = Console.ReadLine();
                    Entry newEntry = new Entry(promptText, entryText);
                    journal.AddEntry(newEntry);
                    break;
                case "2": 
                    journal.DisplayAll();
                    break;
                case "3": 
                    Console.Write("Enter filename to load: ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    break;
                case "4": 
                    Console.Write("Enter filename to save: ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    break;
                case "5": 
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
            Console.WriteLine();
        }

        Console.WriteLine("Goodbye!");
    }
}