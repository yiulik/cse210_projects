public class Prompt
{
    public Prompt()
    {

    }
    public List<string> _prompts = new List<string>();

    public string GetPrompt()
    {
        // Create a list of prompts
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");
        _prompts.Add("What big thing(s) happened today?");
        _prompts.Add("What is one thing that you are most grateful for today?");
        _prompts.Add("What is one thing that you spent a lot of time doing?");

        // Randomize the prompts and ask for input
        Random random = new Random();
        int num = random.Next(_prompts.Count);

        return _prompts[num];
    }
}