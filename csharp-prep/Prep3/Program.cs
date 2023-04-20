using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");
        Random rannum = new Random(); 
        // Console.Write("What is the magic number? ");
        // string ans = Console.ReadLine();
        string again;
        do {
            int magic = rannum.Next(1,101);
            string input;
            int guess;
            int count = 0;
            do {
                Console.Write("What is your guess? ");
                input = Console.ReadLine();
                guess = int.Parse(input);
                count ++;
                if (guess > magic) {
                    Console.WriteLine("Lower");
                }
                else if (guess < magic) {
                    Console.WriteLine("Higher");
                }
                else {
                    Console.WriteLine($"You guessed it! You used {count} guesses!");
                }
            } while (guess != magic);
            Console.WriteLine();
            Console.Write("Do you want to play again (yes/no)? ");
            again = Console.ReadLine();
        } while (again.ToLower() == "yes");
        Console.WriteLine("Thank you for playing!");
    }
}