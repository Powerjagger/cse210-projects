using System;
using System.Collections.Generic;
using System.Linq;

internal class Scripture
{
    private Reference Reference { get; }
    private List<Word> Words { get; }

    public Scripture(Reference reference)
    {
        Reference = reference;
        Words = new List<Word>();
    }

    public void AddWord(string wordText)
    {
        Words.Add(new Word(wordText));
    }

    public void HideRandomWords(int count)
    {
        Random random = new Random();
        var visibleWords = Words.Where(w => w.IsVisible()).ToList();
        int wordsToHide = Math.Min(count, visibleWords.Count);

        for (int i = 0; i < wordsToHide; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public void ReshowAllWords()
    {
        foreach (var word in Words)
        {
            word.Show();
        }
    }

    public string GetRenderedText()
    {
        string text = Reference.ToString() + "\n";
        foreach (var word in Words)
        {
            text += word.GetText() + " ";
        }
        return text.TrimEnd();
    }

    public bool AllWordsHidden()
    {
        return Words.All(w => !w.IsVisible());
    }
}
