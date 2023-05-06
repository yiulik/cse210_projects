public class Reference
{
    private string book, chapter, startVerse, endVerse;
    
    public Reference(string _book, string _chapter, string _start, string _end)
    {
        book = _book;
        chapter = _chapter;
        startVerse = _start;
        endVerse = _end;
    }

    public Reference(string _book, string _chapter, string _start)
    {
        book = _book;
        chapter = _chapter;
        startVerse = _start;
        endVerse = "0";
    }

    public string GetReference()
    {
        if (endVerse == "0")
        {
            return $"{book} {chapter}:{startVerse}";
        }

        else
        {
            return $"{book} {chapter}:{startVerse}-{endVerse}";
        }
    }
}