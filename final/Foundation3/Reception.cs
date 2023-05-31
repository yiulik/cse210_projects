public class Reception : Event
{
    // Attribute
    private string _email;

    // Constructors
    public Reception():base()
    {

    }
    public Reception(string title, string des, string date, string time, Address address, string email):base(title, des, date, time, address)
    {
        _email = email;
    }

    // Methods
    public string Full()
    {
        return $"\nEvent type: Reception{Standard()}\nRSVP: {_email}";
    }
    public string Short()
    {
        return $"\nEvent type: Reception{ShortDetails()}";
    }

    // Getters and Setters
    public string GetEmail()
    {
        return _email;
    }
    public void SetEmail(string email)
    {
        _email = email;
    }
}