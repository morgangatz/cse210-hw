using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Select an activity:");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Listing");
            Console.WriteLine("3. Reflection");
            Console.WriteLine("4. Exit");

            string choice = Console.ReadLine();

            if (choice == "4")
            {
                break;
            }

            Activity activity = null;

            switch (choice)
            {
                case "1":
                    activity = new BreathingActivity();
                    break;
                case "2":
                    activity = new ListingActivity();
                    break;
                case "3":
                    activity = new ReflectingActivity();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    ShowSpinner(3);
                    continue;
            }

            if (activity != null)
            {
                activity.DisplayStartingMessage();
                if (activity is BreathingActivity breathingActivity)
                {
                    breathingActivity.Run();
                }
                else if (activity is ListingActivity listingActivity)
                {
                    listingActivity.Run();
                }
                else if (activity is ReflectingActivity reflectingActivity)
                {
                    reflectingActivity.Run();
                }
                activity.DisplayEndingMessage();
            }
        }
    }

    private static void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b");
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b");
            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b");
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b");
        }
    }
}