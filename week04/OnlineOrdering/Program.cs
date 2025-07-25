using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Maple Street", "Riverton", "UT", "USA");
        Customer customer1 = new Customer("Emily Johnson", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("USB Cable", "P001", 5.99, 3));
        order1.AddProduct(new Product("Wireless Mouse", "P002", 19.99, 1));

        Address address2 = new Address("456 King Road", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Liam Brown", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Laptop Stand", "P010", 35.50, 2));
        order2.AddProduct(new Product("Keyboard Cover", "P011", 8.99, 1));
        order2.AddProduct(new Product("Monitor Light", "P012", 22.75, 1));

        //order 1
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice():0.00}");
        Console.WriteLine();

        //order 2
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice():0.00}");
    }
}