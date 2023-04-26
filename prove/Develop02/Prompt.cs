public class Prompt
{
    public Prompt()
    {

    }
    public List<string> prompts = new List<string>();

    public string GetPrompt()
    {
        // Create a list of prompts
        prompts.Add("Who was the most interesting person I interacted with today?");
        prompts.Add("What was the best part of my day?");
        prompts.Add("How did I see the hand of the Lord in my life today?");
        prompts.Add("What was the strongest emotion I felt today?");
        prompts.Add("If I had one thing I could do over today, what would it be?");
        prompts.Add("What big thing(s) happened today?");
        prompts.Add("What is one thing that you are most grateful for today?");
        prompts.Add("What is one thing that you spent a lot of time doing?");

        // Randomize the promptss and ask for input
        Random random = new Random();
        int num = random.Next(prompts.Count);

        return prompts[num];
    }
}