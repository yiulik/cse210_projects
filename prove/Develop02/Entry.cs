public class Entry
{
    public string _date;
    public string _prompt;
    public string _answer;

    public Entry(string _entryDate, string _entryPrompt, string _entryAnswer)
    {
        _date = _entryDate;
        _prompt = _entryPrompt;
        _answer = _entryAnswer;
    }

    public void DisplayEntry()
    {
        Console.WriteLine($"\nDate: {_date} - Prompt: {_prompt} \n{_answer}");
    }

    public string GetEntryAsCSV()
    {
        return $"Date: {_date}: Prompt: {_prompt}: Answer: {_answer}";
    }
}