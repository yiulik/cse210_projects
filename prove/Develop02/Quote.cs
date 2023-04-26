public class Quote
{
    public Quote()
    {

    }

    public List<string> quotes = new List<string>();

    public string GetQuote()
    {
        quotes.Add("Persist in all things that are good and noble.");
        quotes.Add("Are you a fool playing a genius, or a genius playing a fool?");
        quotes.Add("Reading is like traveling, allowing you to exit your own life for a bit, and to come back with a renewed, even inspired, perspective.");
        quotes.Add("Mastering others is strength. Mastering yourself is TRUE POWER.");
        quotes.Add("Knowledge is of no value unless you put it into practice.");
        quotes.Add("The reading of all good books is like conversation with the finest minds of past centuries.");
        quotes.Add("Reading furnishes the mind only with materials of knowledge; it is thinking that makes what we read ours.");
        
        Random random = new Random();
        int num = random.Next(quotes.Count);

        return quotes[num];
    }
}