using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation4 World!");

        Running running = new Running(DateTime.Now, 30, 5.0);  // 5 km in 30 minutes
        Cycling cycling = new Cycling(DateTime.Now, 45, 20.0); // 20 kph for 45 minutes
        Swimming swimming = new Swimming(DateTime.Now, 60, 30); // 30 laps in 60 minutes
        List<Activity> activities = new List<Activity> { running, cycling, swimming };
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}