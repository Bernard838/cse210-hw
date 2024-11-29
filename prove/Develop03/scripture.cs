using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    // Displaying the scripture (reference + text)//
    public void Display()
    {
        Console.WriteLine(_reference);
        Console.WriteLine(string.Join(" ", _words.Select(word => word.Display())));
    }

    // Hidding random words in the scripture//
    public void HideRandomWords(int count = 3)
    {
        Random random = new Random();
        var visibleWords = _words.Where(word => !word.IsHidden).ToList();

        for (int i = 0; i < count && visibleWords.Count > 0; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    // Checking if all words are hidden//
    public bool IsFullyHidden()
    {
        return _words.All(word => word.IsHidden);
    }
}
