public class Lecture : Event
{
    // Attributes
    private string _speaker, _capacity;
    
    // Constructors
    public Lecture():base()
    {

    }
    public Lecture(string title, string des, string date, string time, Address address, string speaker, string capacity):base(title, des, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    // Methods
    public string Full()
    {
        return $"\nEvent type: Lecture{Standard()}\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }
    public string Short()
    {
        return $"\nEvent type: Lecture{ShortDetails()}";
    }

    // Getters and Setters
    public string GetSpeaker()
    {
        return _speaker;
    }
    public string GetCapacity()
    {
        return _capacity;
    }
    public void SetSpeaker(string speaker)
    {
        _speaker = speaker;
    }
    public void SetCapacity(string capacity)
    {
        _capacity = capacity;
    }
}