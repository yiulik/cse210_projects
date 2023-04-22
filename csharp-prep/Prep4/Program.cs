using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nEnter a list of numbers, type 0 when finished.");
        int input = -1;
        int total = 0;
        int max = 0;
        int min = 10000000;
        float ave;
        List<int> numbers = new List<int>();
        while (input != 0) {
            Console.Write("Enter a number: ");
            string num = Console.ReadLine();
            input = int.Parse(num);
            if (input == 0) {
                break;
            }
            numbers.Add(input);
        }

        foreach (int x in numbers) {
            total += x;
            if (x > max) {
                max = x;
            }
            if (x > 0) {
                if (x < min) {
                    min = x;
                }
            }
        }
        if (numbers.Count != 0) {
            ave = total / numbers.Count;
        }
        else {
            ave = 0;
        }

        numbers.Sort(); 
        Console.WriteLine($"\nThe sum is: {total}");
        Console.WriteLine($"The average is: {ave}");
        Console.WriteLine($"The largest number is: {max}");
        Console.WriteLine($"The smallest positive number is: {min}");
        Console.WriteLine("The sorted list is: ");
        for (int i = 0; i < numbers.Count; i++) {
            Console.WriteLine(numbers[i]);
        }
    }
}