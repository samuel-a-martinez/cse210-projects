public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int? _endVerse; // Nullable int for single verse

    // Constructor for single verse (John 3:16)
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = null; // No end verse
    }

    // Constructor for verse range (Proverbs 3:5-6)
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse; // Start verse is stored in _verse
        _endVerse = endVerse;
    }

    // Helper method to parse a string into a Reference object
    public static Reference ParseString(string refString)
    {
        // Example: "John 3:16" or "Proverbs 3:5-6"
        var parts = refString.Split(' ');
        if (parts.Length < 2)
        {
            throw new ArgumentException("Invalid reference string format.");
        }

        string book = string.Join(" ", parts.Take(parts.Length - 1));
        string chapterVersePart = parts.Last();

        if (chapterVersePart.Contains("-"))
        {
            // Verse range: e.g., "3:5-6"
            var chapterAndVerses = chapterVersePart.Split(':');
            if (chapterAndVerses.Length != 2)
            {
                throw new ArgumentException("Invalid verse range format.");
            }
            int chapter = int.Parse(chapterAndVerses[0]);
            var verseRange = chapterAndVerses[1].Split('-');
            int startVerse = int.Parse(verseRange[0]);
            int endVerse = int.Parse(verseRange[1]);
            return new Reference(book, chapter, startVerse, endVerse);
        }
        else
        {
            // Single verse: e.g., "3:16"
            var chapterAndVerse = chapterVersePart.Split(':');
            if (chapterAndVerse.Length != 2)
            {
                throw new ArgumentException("Invalid single verse format.");
            }
            int chapter = int.Parse(chapterAndVerse[0]);
            int verse = int.Parse(chapterAndVerse[1]);
            return new Reference(book, chapter, verse);
        }
    }

    public string GetDisplayText()
    {
        if (_endVerse.HasValue)
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}";
        }
    }
}