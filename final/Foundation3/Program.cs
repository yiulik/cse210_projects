using System;

class Program
{
    static void Main(string[] args)
    {
        Address a1 = new Address("525 S 2nd E", "Rexburg", "Idaho", "USA");
        Lecture l1 = new Lecture("Micro & Macro Biology", "This event will introduce to the audiences an overview of micro and macro biology. Refreshments will be provided afterwards.", "June 06, 2023", "17:00 - 18:00", a1, "Jonathan Joestar", "100");
        Console.WriteLine("\nEvent 1");
        Console.WriteLine(l1.Standard());
        Console.WriteLine(l1.Full());
        Console.WriteLine(l1.Short());

        Address a2 = new Address("570 S 2nd W", "Rexburg", "Idaho", "USA");
        Reception r1 = new Reception("Made In Heaven is coming!", "This event is held for the famous performing group Made In Heaven as they plan to hold a concert in Rexburg, Idaho. \nThey will have a reception for fans to come to see them and non-fans to get to know them.", "June 03, 2023", "05:00 p.m. - 07:00 p.m.", a2, "mih@gmail.com");
        Console.WriteLine("\nEvent 2");
        Console.WriteLine(r1.Standard());
        Console.WriteLine(r1.Full());
        Console.WriteLine(r1.Short());

        Address a3 = new Address("123 N 3rd E", "Rexburg", "Idaho", "USA");
        OutdoorGathering o1 = new OutdoorGathering("School Picnic", "This event is held by the Brigham Young University - Idaho for its students and their friends to come together and get to know each other. \nAlumni are invited as well.", "June 10, 2023", "11:30 a.m. - 01:30 p.m.", a3, "It will be a sunny day.");
        Console.WriteLine("\nEvent 3");
        Console.WriteLine(o1.Standard());
        Console.WriteLine(o1.Full());
        Console.WriteLine(o1.Short());
    }
}