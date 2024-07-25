using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!");

        Address lectureAddress = new Address("123 Main St", "Anytown", "CA", "12345");
        Lecture lecture = new Lecture("Tech Talk", "A talk on the latest in technology.", DateTime.Now, "10:00 AM", lectureAddress, "Dr. Smith", 100);
        Address receptionAddress = new Address("456 Elm St", "Anytown", "CA", "12345");
        Reception reception = new Reception("Company Party", "Annual company gathering.", DateTime.Now.AddDays(5), "7:00 PM", receptionAddress, "rsvp@company.com");
        Address outdoorAddress = new Address("789 Oak St", "Anytown", "CA", "12345");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Summer Picnic", "Outdoor picnic for all employees.", DateTime.Now.AddMonths(1), "12:00 PM", outdoorAddress, "Sunny");
        // Output the marketing messages
        Console.WriteLine("Lecture Standard Details:");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine("Reception Full Details:");
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine("Outdoor Gathering Short Description:");
        Console.WriteLine(outdoorGathering.GetShortDescription());
        Console.WriteLine();
    }
}