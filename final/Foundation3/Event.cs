 public class Event
{
    private string title;
    private string description;
    private DateTime date;
    private string time;
    private Address address;
    public Event(string title, string description, DateTime date, string time, Address address)
    {
        this.title = title;
        this.description = description;
        this.date = date;
        this.time = time;
        this.address = address;
    }
    public virtual string GetStandardDetails()
    {
        return $"Title: {title}\nDescription: {description}\nDate: {date.ToShortDateString()}\nTime: {time}\nAddress: {address}";
    }
    public virtual string GetFullDetails()
    {
        return GetStandardDetails() + "\n";
    }
    public virtual string GetShortDescription()
    {
        return $"Event: {title}\nDate: {date.ToShortDateString()}";
    }
}