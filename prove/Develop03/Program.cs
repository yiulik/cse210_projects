using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        // Reference ref1 = new Reference("Proverbs", "3", "5", "6");
        Scripture scr1 = new Scripture();
        string ans = "";
        Console.Clear();
        Console.WriteLine(scr1.GetScripture());
        Console.WriteLine("\nPress enter to continue or type 'quit' to finish: ");
        ans = Console.ReadLine();
        while (ans != "quit" && scr1.HasWordsLeft() == true)
        {
            Console.Clear();
            scr1.RemoveWords();
            Console.WriteLine(scr1.GetScripture());
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish: ");
            ans = Console.ReadLine();
        }
    }
}