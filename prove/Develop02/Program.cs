using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Starting the program
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
        Console.Write("What would you like to do? ");
        string option = Console.ReadLine();

        // Make an empty list to store custom objects
        List<Entry> emptyList = new List<Entry>();

        do {
            if (option == "1") {
                Entry newEntry = NewEntry();
                emptyList.Add(newEntry);
            } 

            else if (option == "2") {
                foreach (Entry e in emptyList) {
                    e.Display();
                }
            }

            else if (option == "3") {
                Console.WriteLine("What is the filename?");
                string filename = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines(filename);
                emptyList = new List<Entry>();
                foreach (string line in lines) {
                    string[] parts = line.Split(": ");

                    Entry entry = new Entry();
                    entry._date = parts[1];
                    entry._prompt = parts[3];
                    entry._answer = parts[5];

                    emptyList.Add(entry);
                }
            }

            else if (option == "4") {
                File f = WriteFile(emptyList);
            }

            else {
                Console.WriteLine("Invalid input...");
            }

            // Show the menu to the user and ask for an option
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            Console.Write("What would you like to do? ");
            option = Console.ReadLine();

        } while (option != "5");
        Console.WriteLine("\nThanks for using this app!");
    }

    static Entry NewEntry() 
    {
        // Create a list of prompts
        List<string> prompt = new List<string>();
        prompt.Add("Who was the most interesting person I interacted with today?");
        prompt.Add("What was the best part of my day?");
        prompt.Add("How did I see the hand of the Lord in my life today?");
        prompt.Add("What was the strongest emotion I felt today?");
        prompt.Add("If I had one thing I could do over today, what would it be?");
        prompt.Add("What big thing(s) happened today?");
        prompt.Add("What is one thing that you are most grateful for today?");
        prompt.Add("What is one thing that you spent a lot of time doing?");

        // Randomize the prompts and ask for input
        Random random = new Random();
        int num = random.Next(prompt.Count);
        Console.WriteLine(prompt[num]);
        Console.Write(">");
        string ans = Console.ReadLine();

        // Create a new Entry object
        Entry newEntry = new Entry();
        newEntry._date = DateTime.Today.ToShortDateString();
        newEntry._prompt = prompt[num];
        newEntry._answer = ans;

        return newEntry;
    }

    static File WriteFile(List<Entry> entry) 
    {
        // Create a new File object
        File newFile = new File();
        Console.WriteLine("What is the filename?");
        newFile._name = Console.ReadLine();

        // Open the file and write to it
        using (StreamWriter outputFile = new StreamWriter(newFile._name)) {
            foreach (Entry e in entry) {
                outputFile.WriteLine($"Date: {e._date}: Prompt: {e._prompt}: Answer: {e._answer}");
                newFile._entries.Add(e);  // Add the entries to a single file
            }
        }
        return newFile;
    }
}
