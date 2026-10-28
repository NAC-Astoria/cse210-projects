public class  Reference
{
    string _book;
    int _chapter;
    int _verseStart;
    int _verseEnd;

    public Reference(string book, int chapter, int verseStart)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verseStart;
        _verseEnd = 0;
    }
    public Reference(string book, int chapter, int verseStart, int verseEnd)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verseStart;
        _verseEnd = verseEnd;
    }

    public string GetDisplayText()
    {
        if (_verseEnd > 0)
        {
            return $"{_book} {_chapter}:{_verseStart}-{_verseEnd}";
        }
        return $"{_book} {_chapter}:{_verseStart}";
    }
}
