using System;

public class Reference
{
    private string _book;
    private string _startVerse;
    private string _endVerse;

    // Getting the Constructor for a single verse
    public Reference(string book, string startVerse)
    {
        _book = book;
        _startVerse = startVerse;
        _endVerse = null;
    }

    //Getting the Constructor for a range of verses
    public Reference(string book, string startVerse, string endVerse)
    {
        _book = book;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    // Returning the formatted reference
    public override string ToString()
    {
        return _endVerse == null ? $"{_book} {_startVerse}" : $"{_book} {_startVerse}-{_endVerse}";
    }
}
