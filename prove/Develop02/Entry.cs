public class Entry
{
    public string _date;
    public string _prompt;
    public string _answer;
    public void Display() {
        Console.WriteLine($"\nDate: {_date} - Prompt: {_prompt} \nAnswer: {_answer}");
        // Console.WriteLine($"{_answer}");
    }
}