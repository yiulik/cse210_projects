public class Entry
{
    public string _date;
    public string _prompt;
    public string _answer;
    public string _quote;

    public Entry(string _entryDate, string _entryPrompt, string _entryAnswer, string _entryQuote)
    {
        _date = _entryDate;
        _prompt = _entryPrompt;
        _answer = _entryAnswer;
        _quote = _entryQuote;
    }

    public void DisplayEntry()
    {
        Console.WriteLine($"\nDate: {_date} - Prompt: {_prompt} \n{_answer} \nQuote: {_quote}");
    }

    public string GetEntryAsCSV()
    {
        return $"Date: {_date}: Prompt: {_prompt}: Answer: {_answer}: Quote: {_quote}";
    }
}