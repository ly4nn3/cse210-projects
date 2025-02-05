using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
    
        Address usAddress = new Address("3744 University Hill Road", "Effingham", "Illinois", "USA");
        Address internationalAddress = new Address("4328 Burdett Avenue", "Victoria", "British Columbia", "Canada");

        Customer usCustomer = new Customer("John Doe", usAddress);
        Customer internationalCustomer = new Customer("Jane Doe", internationalAddress);

        Product laptop = new Product("Laptop", 1001, 900.99f, 2);
        Product headphones = new Product("Headphones", 2001, 85.99f, 2);
        Product deskMat = new Product("Desk Mat", 3001, 49.99f, 1);

        List<Product> order1Products = new List<Product> { laptop, deskMat };
        List<Product> order2Products = new List<Product> { laptop, headphones, deskMat };
        
        Order order1 = new Order(order1Products, usCustomer);
        Order order2 = new Order(order2Products, internationalCustomer);

        Console.WriteLine("\nOrder 1 Details:");
        Console.WriteLine("----------------");
        Console.WriteLine($"Packing Label:\n{order1.GetPackingLabel()}");
        Console.WriteLine($"Shipping Label:\n{order1.GetShippingLabel()}");
        Console.WriteLine($"Total Price: ${order1.CalculateTotalPrice()}");

        Console.WriteLine("\nOrder 2 Details:");
        Console.WriteLine("----------------");
        Console.WriteLine($"Packing Label:\n{order2.GetPackingLabel()}");
        Console.WriteLine($"Shipping Label:\n{order2.GetShippingLabel()}");
        Console.WriteLine($"Total Price: ${order2.CalculateTotalPrice()}");
    }
}