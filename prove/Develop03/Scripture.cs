public class Scripture
{

    Reference _reference;
    List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] singleWords = text.Split();
        foreach ( string singleWord in singleWords)
        {
            Word newWord = new Word(singleWord);
            _words.Add(newWord);
        }
    }
    
    public void DisplayText()
    {
        Console.WriteLine($"{_reference.GetDisplayText()}");
        foreach (Word word in _words)
        {
            Console.Write($"{word.GetDisplayText()} ");
        }
        Console.WriteLine();
    }
}