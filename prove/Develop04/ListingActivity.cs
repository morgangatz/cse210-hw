public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity(){
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _prompts = new List<string>{
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public void Run(){
        DisplayStartingMessage();
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
        ShowCountdown(5);
        List<string> items = GetListFromUser();
        _count = items.Count;
        DisplayEndingMessage();
        Console.WriteLine($"You listed {_count} items.");
        ShowSpinner(3);
    }

    private string GetRandomPrompt(){
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }

    private List<string> GetListFromUser(){
        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        Console.WriteLine("Start listing items:");
        while (DateTime.Now < endTime)
        {
            string item = Console.ReadLine();
            items.Add(item);
        }
        return items;
    }
}