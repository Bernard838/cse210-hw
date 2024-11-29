using System;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false; // Default to visible
    }

    // Hidding the word
    public void Hide()
    {
        _isHidden = true;
    }

    // Checking if the word is hidden
    public bool IsHidden => _isHidden;

    // Displaying the hidden words with underscores 
    public string Display()
    {
        return _isHidden ? new string('_', _text.Length) : _text;
    }
}
