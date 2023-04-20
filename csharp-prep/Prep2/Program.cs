using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string percentage = Console.ReadLine();
        int grade = int.Parse(percentage);
        string letter;
        int lastDigit = grade % 10;
        string sign;

        if (grade > 70) 
        {
            Console.WriteLine("Congrats! You passed the course!");
        }
        else
        {
            Console.WriteLine("Never give up! Do better next time!");
        }

        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }
        else 
        {
            sign = "";
        }

        if (grade >= 90) 
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }

        if (letter == "A")
        {
            if (lastDigit < 3) 
            {
                sign = "-";
            }
            else 
            {
                sign = "";
            }
        }

        if (letter == "F")
        {
            sign = "";
        }
        
        Console.WriteLine($"Your grade is {letter}{sign}");
    }
}