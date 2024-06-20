public class Entry{
    public string _date;
    public string _promptText;
    public string _entry;

    public Entry(string prompt, string entry){
        _date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        _promptText = prompt;
        _entry = entry;
    }

    // Constructor for loading entries from file
    public Entry(string prompt, string entry, string date){
        _date = date;
        _promptText = prompt;
        _entry = entry;
    }
    public void Display(){
        DateTime theCurrentTime = DateTime.Now;
        _date = theCurrentTime.ToShortDateString();
        Console.WriteLine($"{_date} >");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Response: {_entry}");
        Console.WriteLine();
    }

}