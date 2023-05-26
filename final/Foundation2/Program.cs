using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1
        List<Product> products1 = new List<Product>();
        Customer c1 = new Customer("Mary", new Address("33 Castle Peak Rd", "Yuen Long", "Hong Kong", "China"));
        products1.Add(new Product("Fan", "0102", 19.99, 2));
        products1.Add(new Product("Toaster", "0200", 21.99, 1));
        products1.Add(new Product("Chair", "0210", 34.99, 4));
        Order o1 = new Order(products1, c1);
        
        // Order 2
        List<Product> products2 = new List<Product>();
        Customer c2 = new Customer("John", new Address("525 S 2nd W", "Rexburg", "Idaho", "USA"));
        products2.Add(new Product("Bread", "0134", 5.99, 3));
        products2.Add(new Product("Cup Noodle", "0225", 2.99, 10));
        products2.Add(new Product("Apple", "0121", 4.99, 12));
        Order o2 = new Order(products2, c2);

        Console.WriteLine($"\nPacking Label: {o1.Packing()}\n\nShipping Label: \n{o1.Shipping()}\n\nTotal Price: ${o1.TotalCost()}\n");
        Console.WriteLine($"Packing Label: {o2.Packing()}\n\nShipping Label: \n{o2.Shipping()}\n\nTotal Price: ${o2.TotalCost()}\n");
    }
}