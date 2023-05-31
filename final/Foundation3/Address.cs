public class Address
{
    // Attributes
    private string _street, _city, _state, _country;

    // Constructors
    public Address()
    {

    }
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    // Methods
    public bool IsUSA()
    {
        return _country == "USA";
    }
    public string MakeAddress()
    {
        return $"{_street},\n{_city}, {_state}, {_country}";
    }

    // Getters and Setters
    public string GetStreet()
    {
        return _street;
    }
    public string GetCity()
    {
        return _city;
    }
    public string GetState()
    {
        return _state;
    }
    public string GetCountry()
    {
        return _country;
    }
    public void SetStreet(string street)
    {
        _street = street;
    }
    public void SetCity(string city)
    {
        _city = city;
    }
    public void SetState(string state)
    {
        _state = state;
    }

    public void SetCountry(string country)
    {
        _country = country;
    }
}