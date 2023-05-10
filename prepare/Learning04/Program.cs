using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment as1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(as1.GetSummary());

        MathAssignment mas1 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(mas1.GetSummary());
        Console.WriteLine(mas1.GetHomeworkList());

        WritingAssignment was1 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(was1.GetSummary());
        Console.WriteLine(was1.GetWritingInformation());
    }
}