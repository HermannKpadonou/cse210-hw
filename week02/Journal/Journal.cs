using System;
using System.IO;
using System.Collections.Generic;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries to display.");
            return;
        }

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        try
        {
            using (StreamWriter outputFile = new StreamWriter(file))
            {
                foreach (Entry entry in _entries)
                {
                    outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
                }
            }
            Console.WriteLine($"Journal saved to {file}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving file: {ex.Message}");
        }
    }

    public void LoadFromFile(string file)
    {
        try
        {
            if (!File.Exists(file))
            {
                Console.WriteLine($"File '{file}' does not exist. No entries loaded.");
                return;
            }

            
            string[] lines = File.ReadAllLines(file);
            
            _entries.Clear();
            int loadedCount = 0;
            
            foreach (string line in lines)
            {
                
                string[] parts = line.Split('|');
                
                if (parts.Length == 3)
                {
                    Entry entry = new Entry(parts[0], parts[1], parts[2]);
                    _entries.Add(entry);
                    loadedCount++;
                }
            }
            Console.WriteLine($"Loaded {loadedCount} entries from {file}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading file: {ex.Message}");
        }
    }
}