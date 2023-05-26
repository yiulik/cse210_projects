public class Customer
{
    private string _name;
    private Address _address;

    public Customer()
    {

    }
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool GetIsUSA()
    {
        return _address.IsUSA();
    }

    // Getters and Setters
    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public string GetAddress()
    {
        return _address.MakeAddress();
    }
}