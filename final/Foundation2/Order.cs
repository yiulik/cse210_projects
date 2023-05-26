public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order()
    {

    }
    public Order (List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }
    public double TotalCost()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.TotalPrice();
        }
        if (_customer.GetIsUSA() == true)
        {
            total += 5;
        }
        else 
        {
            total += 35;
        }
        return total;
    }
    public string Packing()
    {
        string details = "";
        // List<string> details = new List<string>();
        foreach (Product product in _products)
        {
            // details.Add($"Name: {product.GetName()}\nProduct ID: {product.GetId()}");
            details += $"\n{product.GetName()} ({product.GetId()})";
        }
        return details;
    }
    public string Shipping()
    {
        return $"Name: {_customer.GetName()}\nAddress: \n{_customer.GetAddress()}";
    }
}