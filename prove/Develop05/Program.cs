using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Goal Tracker!");
        string opt = "";
        List<Goal> goalList = new List<Goal>();
        Goal g = new Goal();
        while (opt != "6")
        {
            g.DisplayMenu();
            opt = Console.ReadLine();

            if (opt == "1")
            {
                Console.WriteLine("The types of goals are:");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");
                Console.Write("Which type of goal would you like to create? ");
                string opt2 = Console.ReadLine();
                if (opt2 == "1")
                {
                    SimpleGoal g1 = new SimpleGoal();
                    g1.CreateGoal();
                    goalList.Add(g1);
                }
                else if (opt2 == "2")
                {
                    EternalGoal g2 = new EternalGoal();
                    g2.CreateGoal();
                    goalList.Add(g2);
                }
                else if (opt2 == "3")
                {
                    ChecklistGoal g3 = new ChecklistGoal();
                    g3.CreateGoal();
                    goalList.Add(g3);
                }
            }
            else if (opt == "2")
            {
                Console.WriteLine("Your goals are: ");
                g.DisplayGoal(goalList);
            }
            else if (opt == "3")
            {
                g.Save(goalList);
            }
            else if (opt == "4")
            {
                goalList = g.Load(goalList); 
            }
            else if (opt == "5")
            {
                g.Record(goalList);
            }
        }
    }
}