public class Address
{
    private string _street, _city, _state, _country;

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

    public bool IsUSA()
    {
        return _country == "USA";
    }
    public string MakeAddress()
    {
        return $"{_street},\n{_city}, {_state}, {_country}";
    }
}