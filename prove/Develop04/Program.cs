using System;

class Program
{
    static void Main(string[] args)
    {
        string ans = "";
        while (ans != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflection activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            ans = Console.ReadLine();
            if (ans == "1")
            {
                BreathingActivity a1 = new BreathingActivity();
                a1.SetName("Breathing Activity");
                a1.SetDes("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
                a1.StartMsg();
                a1.PrepareMsg();
                a1.Breathing();
                a1.EndMsg();
            }
            else if (ans == "2")
            {
                ReflectionActivity a2 = new ReflectionActivity();
                a2.SetName("Reflection Activity");
                a2.SetDes("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                a2.StartMsg();
                a2.PrepareMsg();
                a2.reflect();
                a2.EndMsg();
            }
            else if (ans == "3")
            {
                ListingActivity a3 = new ListingActivity();
                a3.SetName("Listing Activity");
                a3.SetDes("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                a3.StartMsg();
                a3.PrepareMsg();
                a3.Listing();
                a3.EndMsg();
            }
            else if (ans == "4")
            {
                Console.WriteLine("\nThank you for using the application!");
            }

            else
            {
                Console.WriteLine("Invalid option... Please choose again");
                Thread.Sleep(1000);
            }
        }
    }
}