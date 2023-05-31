using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        // Console.WriteLine("\nWelcome to the exercise tracker!");
        // string ans = "";
        // while (ans != "4")
        // {
        //     Console.WriteLine("\nPlease choose one of the following to record:\n1. Running\n2. Cycling\n3. Swimming\n4. Quit");
        //     Console.Write("\nWhich of the above would you like to record? ");
        //     ans = Console.ReadLine();
        //     if (ans == "1")
        //     {
        //         Running r = new Running();
        //         r.GetInfo();
        //         activities.Add(r);
        //     }
        //     else if (ans == "2")
        //     {
        //         Cycling c = new Cycling();
        //         c.GetInfo();
        //         activities.Add(c);
        //     }
        //     else if (ans == "3")
        //     {
        //         Swimming s = new Swimming();
        //         s.GetInfo();
        //         activities.Add(s);
        //     }
        // }
        Running r = new Running();
        Console.WriteLine("Running:");
        r.GetInfo();
        activities.Add(r);

        Cycling c = new Cycling();
        Console.WriteLine("Cycling:");
        c.GetInfo();
        activities.Add(c);

        Swimming s = new Swimming();
        Console.WriteLine("Swimming:");
        s.GetInfo();
        activities.Add(s);

        Console.WriteLine("\nSummary:");
        foreach (Activity a in activities)
        {
            a.GetSummary();
        }
    }
}