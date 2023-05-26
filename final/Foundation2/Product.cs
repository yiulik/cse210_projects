public class Product
{
    private string _name, _productId;
    private int _quantity;
    private double _price;

    public Product()
    {

    }
    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }
    public double TotalPrice()
    {
        return _price * _quantity;
    }

    // Getters and Setters
    public string GetName()
    {
        return _name;
    }
    public string GetId()
    {
        return _productId;
    }
    public int GetQuantity()
    {
        return _quantity;
    }
    public double GetPrice()
    {
        return _price;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public void SetId(string id)
    {
        _productId = id;
    }
    public void SetPrice(double price)
    {
        _price = price;
    }
    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }
}