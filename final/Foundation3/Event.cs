public class Event
{
    // Attributes
    private string _title, _description, _date, _time;
    private Address _address;
    
    // Constructors
    public Event()
    {

    }
    public Event(string title, string des, string date, string time, Address address)
    {
        _title = title;
        _description = des;
        _date = date;
        _time = time;
        _address = address;
    }

    // Methods
    public string Standard()
    {
        return $"\nEvent title: {_title}\nDescriptions: {_description}\nDate & Time: {_date} at {_time}\nAddress: \n{_address.MakeAddress()}";
    }
    public string ShortDetails() 
    {
        return $"\nTitle: {_title}\nDate: {_date}";
    }

    // Getters and Setters
    public void SetTitle(string title)
    {
        _title = title;
    }
    public void SetDes(string des)
    {
        _description = des;
    }
    public void SetDate(string date)
    {
        _date = date;
    }
    public void SetTime(string time)
    {
        _time = time;
    }
    public string GetTitle()
    {
        return _title;
    }
    public string GetDes()
    {
        return _description;
    }
    public string GetDate()
    {
        return _date;
    }
    public string GetTime()
    {
        return _time;
    }
    public string GetAddress()
    {
        return _address.MakeAddress();
    }
}