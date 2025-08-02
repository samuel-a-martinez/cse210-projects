using System;

class Program
{
    static void Main(string[] args)
    {
        // Example scriptures
        Reference ref1 = Reference.ParseString("John 3:16");            string text1 = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
        Scripture scripture1 = new Scripture(ref1, text1);

        Reference ref2 = Reference.ParseString("Proverbs 3:5-6");
        string text2 = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
        Scripture scripture2 = new Scripture(ref2, text2);

        // Choose which scripture to use for practice
        Scripture currentScripture = scripture2; // Change to scripture2 to practice the other one

        while (true)
        {
            Console.Clear();
            Console.WriteLine(currentScripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to finish:");
            string userInput = Console.ReadLine().ToLower().Trim();

        if (userInput == "quit")
        {
            Console.WriteLine("Exiting program.");
            break;
        }

        if (currentScripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(currentScripture.GetDisplayText()); // Final display with all words hidden
            Console.WriteLine("\nAll words are hidden. Good job! Program ending.");
            break;
        }

        // Hide 2 to 4 words at a time, chosen randomly
        Random rnd = new Random();
        currentScripture.HideRandomWords(rnd.Next(2, 5)); // Next(min, max) is exclusive for max
        }
    }
}

