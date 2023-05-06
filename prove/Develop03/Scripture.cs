public class Scripture
{
    private List<Word> words = new List<Word>();
    private Reference scriptureRef;
    

    // To exceed the requirements, I added three more methods: GetRanScript(), GetRef(), Refer()
    public Scripture()
    {
        // Generate a random number between 1 and 5 
        // and pass that number to the GetRanScript() and Refer() methods 
        // to get the corresponding reference and scripture text.
        Random random = new Random();
        int num = random.Next(1,6);

        scriptureRef = GetRef(Refer(num));
        CreateWords(GetRanScript(num));
    }

    public void CreateWords(string _scriptContent)
    {
        List<string> manyWords = _scriptContent.Split(" ").ToList();
        foreach (string thing in manyWords)
        {
            Word word = new Word(thing);
            words.Add(word);
        }
    }

    public string GetScripture()
    {
        string content = "";
        foreach (Word word in words)
        {
            if (word.GetIsHidden() == false) 
            {
                content += word.GetWord() + " ";
            }
            else 
            {
                content += new string('_', word.GetWord().Length) + " ";
            }
        }
        return $"{scriptureRef.GetReference()} {content}";
    }

    public string GetRanScript(int num)
    {
        // Make a list of string to store different scripture texts
        List<string> scripts = new List<string>();
        scripts.Add("And my father dewlt in a tent.");
        scripts.Add("Adam fell that men might be; and men are, that they might have joy.");
        scripts.Add("These things I command you, that ye love one another.");
        scripts.Add("For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life." +
        "For God sent not his Son into the world to condemn the world; but that the world through him might be saved.");
        scripts.Add("Therefore, dearly beloved brethren, let us cheerfully do all things that lie in our power; and then may we stand still, with the utmost assurance, to see the salvation of God, and for his arm to be revealed.");

        return scripts[num - 1];
    }

    public Reference GetRef(string refer)
    {
        // Make a list of string to store the scripture references and transfer them into Reference objects
        List<string> reference = refer.Split("/").ToList();
        if (reference.Count() == 3) 
        {
            return new Reference(reference[0], reference[1], reference[2]);
        }
        return new Reference(reference[0], reference[1], reference[2], reference[3]="0");
    }

    public string Refer(int num)
    {
        // Make a list of string to store the scripture references
        List<string> refer = new List<string>();
        refer.Add("1 Nephi/2/15");
        refer.Add("2 Nephi/2/25");
        refer.Add("John/15/17");
        refer.Add("John/3/16/17");
        refer.Add("Doctrine and Covenants/123/17");

        return refer[num - 1];
    }

    public bool HasWordsLeft()
    {
        foreach (Word word in words)
        {
            if (word.GetIsHidden() == false)
            {
                return true;
            }
        }
        return false;
    }

    public void RemoveWords()
    {
        int numberWordsRemove = new Random().Next(2, 4);
        int wordsRemoved = 0;

        do 
        {
            int ranIndex = new Random().Next(0, words.Count());
            if (words[ranIndex].GetIsHidden() == false)
            {
                words[ranIndex].SetIsHidden(true);
                wordsRemoved++;
            }
        } while (wordsRemoved != numberWordsRemove && this.HasWordsLeft());
    }
}