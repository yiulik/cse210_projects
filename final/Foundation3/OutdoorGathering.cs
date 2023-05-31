public class OutdoorGathering : Event
{
    // Attribute
    private string _weather;

    // Constructors
    public OutdoorGathering()
    {

    }
    public OutdoorGathering(string title, string des, string date, string time, Address address, string weather):base(title, des, date, time, address)
    {
        _weather = weather;
    }

    // Methods
    public string Full()
    {
        return $"{Standard()}\nEvent type: Outdoor Gathering\nWeather forecast: {_weather}";
    }
    public string Short()
    {
        return $"\nEvent type: Outdoor Gathering{ShortDetails()}";
    }

    // Getters and Setters
    public string GetWeather()
    {
        return _weather;
    }
    public void SetWeather(string weather)
    {
        _weather = weather;
    }
}