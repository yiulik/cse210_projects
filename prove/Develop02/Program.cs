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
        Console.Write("\nWhat would you like to do? ");
        string option = Console.ReadLine();        
        
        // Create a new Journal object 
        Journal newJournal = new Journal();

        // Begins a loop to keep asking the user for an option
        do {
            if (option == "1") {
                newJournal.CreateEntry();
            } 

            else if (option == "2") {
                newJournal.DisplayEntries();
            }

            else if (option == "3") {
                newJournal.LoadFile();
            }

            else if (option == "4") {
                newJournal.SaveFile();
            }

            else {
                Console.WriteLine("Invalid input...");
            }

            // Show the menu to the user again and ask for an option
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            Console.Write("What would you like to do? ");
            option = Console.ReadLine();

        } while (option != "5");
        Console.WriteLine("\nThanks for using this app!");
    }
}