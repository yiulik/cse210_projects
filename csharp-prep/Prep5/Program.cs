using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNum = PromptUserNumber();
        int nn = SquareNumber(userNum);
        DisplayResult(userName, nn);
    }
    static void DisplayWelcome() 
    {
        Console.WriteLine("\nWelcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string number = Console.ReadLine();
        int num = int.Parse(number);
        return num;
    }
    
    static int SquareNumber(int n)
    {
        return n * n;
    }

    static void DisplayResult(string user, int n2)
    {
        Console.WriteLine($"{user}, the square of your number is {n2}");
    }
}