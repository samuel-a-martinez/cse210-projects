using System;
using System.Collections.Generic;
using System.IO;
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
            Console.WriteLine("The journal is empty.");
        }
        else
        {
            foreach (Entry entry in _entries)
            {
                entry.Display();
            }
        }
    }
    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}. ~~ Promp:{entry._promptText}. ~~ {entry._entryText}");
            }
        }
        Console.WriteLine("Journal saved successfully.");
    }
    public void LoadFromFile(string file)
    {
        _entries.Clear();
        try
        {
            string[] lines = System.IO.File.ReadAllLines(file);
            foreach (string line in lines)
            {
                string[] parts = line.Split(new string[] { ". ~~ Promp:", ". ~~ " }, StringSplitOptions.None);
                if (parts.Length == 3)
                {
                    string date = parts[0].Trim();
                    string prompt = parts[1].Trim();
                    string entryText = parts[2].Trim();
                    Entry newEntry = new Entry
                    {
                        _date = parts[0],
                        _promptText = parts[1],
                        _entryText = parts[2]
                    };

                    _entries.Add(newEntry);
                }
                else
                {
                    Console.WriteLine($"Warning: could not parse line {line}, expected 3 parts, got {parts.Length} ");
                }
            }
            Console.WriteLine("Journal loaded successfully.");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"Error: The file '{file}' was not found.");
        }
    }
}