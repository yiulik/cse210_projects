public class Journal
{
    public Journal()
    {

    }

    public List<Entry> _entryList = new List<Entry>();

    public void DisplayEntries() 
    {
        foreach (Entry e in _entryList)
        {
            e.DisplayEntry();
        }
    }

    public void CreateEntry()
    {
        string date = DateTime.Today.ToShortDateString();
        Quote q = new Quote();
        string quote = q.GetQuote();
        Console.WriteLine($"\nQuote: {quote}");
        Prompt ppt = new Prompt();
        string prompt = ppt.GetPrompt();
        Console.WriteLine(prompt);
        Console.Write(">");
        string ans = Console.ReadLine();
        Entry newEntry = new Entry(date, prompt, ans, quote);
        _entryList.Add(newEntry);
    }

    public void SaveFile() 
    {
        Console.WriteLine("\nWhat is the filename? ");
        string  filename = Console.ReadLine();
        List<string> stringList = new List<string>();
        using (StreamWriter outputFile = new StreamWriter(filename)) 
        {
            foreach (Entry e in _entryList) 
            {
                stringList.Add(e.GetEntryAsCSV());
            }
            foreach (string i in stringList)
            {
                outputFile.WriteLine(i);

            }
        }
    }

    public void LoadFile()
    {
        _entryList = new List<Entry>();
        Console.WriteLine("\nWhat is the filename? ");
        string loadFile = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(loadFile);
        foreach (string line in lines) 
        {
            string[] parts = line.Split(": ");
            string date = parts[1];
            string prompt = parts[3];
            string answer = parts[5];
            string quote = parts[7];
            Entry newEn = new Entry(date, prompt, answer, quote);
            _entryList.Add(newEn);
        }
    }
}