using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading; // For Thread.Sleep if needed for console clarity

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        // Split the text into words, handling common punctuation to keep words clean
        // This regex splits by spaces and common punctuation, keeping punctuation attached to words for display
        // unless it's a standalone punctuation mark.
        string[] rawWords = Regex.Split(text, @"(?<=[.,;!?:])|\s+");
        foreach (string w in rawWords)
        {
            if (!string.IsNullOrWhiteSpace(w))
            {
                _words.Add(new Word(w.Trim()));
            }
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        var unhiddenWords = _words.Where(w => !w.IsHidden()).ToList();
        if (!unhiddenWords.Any())
        {
            return; // All words are already hidden
        }

        Random random = new Random();
        int actualWordsToHide = Math.Min(numberToHide, unhiddenWords.Count);

        // Shuffle the unhidden words and take the first 'actualWordsToHide'
        List<Word> shuffledUnhiddenWords = unhiddenWords.OrderBy(x => random.Next()).ToList();

        for (int i = 0; i < actualWordsToHide; i++)
        {
            shuffledUnhiddenWords[i].Hide();
        }
    }

    public string GetDisplayText()
    {
        string wordsDisplay = string.Join(" ", _words.Select(w => w.GetDisplayText()));
        return $"{_reference.GetDisplayText()} {wordsDisplay}";
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}