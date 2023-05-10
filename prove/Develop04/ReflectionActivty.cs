public class ReflectionActivity:Activity
{
    public ReflectionActivity():base()
    {

    }
    public ReflectionActivity(string name, string description, int duration):base(name, description, duration)
    {

    }
    public void reflect()
    {
        Console.WriteLine("\nConsider the following prompt:");
        string prompt = GetPrompts();
        Console.WriteLine($"\n --- {prompt} --- ");
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in : ");
        Countdown(5);
        Console.Clear();

        DateTime start = DateTime.Now;
        DateTime endTime = start.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            string question = GetQuestions();
            Console.Write($"\n> {question} ");
            Spinner(15);
        }
        Console.WriteLine("");
    }
    public string GetPrompts()
    {
        List<string> prompts = new List<string>();
        prompts.Add("Think of a time when you stood up for someone else.");
        prompts.Add("Think of a time when you did something really difficult.");
        prompts.Add("Think of a time when you helped someone in need.");
        prompts.Add("Think of a time when you did something truly selfless.");
        Random rnd = new Random();
        int i = rnd.Next(prompts.Count);
        return prompts[i];
    }
    public string GetQuestions()
    {
        List<string> questions = new List<string>();
        questions.Add("Why was this experience meaningful to you?");
        questions.Add("Have you ever done anything like this before?");
        questions.Add("How did you get started?");
        questions.Add("How did you feel when it was complete?");
        questions.Add("What made this time different than other times when you were not as successful?");
        questions.Add("What is your favorite thing about this experience?");
        questions.Add("What could you learn from this experience that applies to other situations?");
        questions.Add("What did you learn about yourself through this experience?");
        questions.Add("How can you keep this experience in mind in the future?");
        Random rnd = new Random();
        int i = rnd.Next(questions.Count);
        return questions[i];
    }
}