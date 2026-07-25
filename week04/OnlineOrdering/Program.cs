using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1 (RSA)
        Address address1 = new Address(
            "123 Main Street",
            "New York",
            "NY",
            "RSA");

        Customer customer1 = new Customer("John Smith", address1);

        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Laptop", "P101", 800, 1));
        order1.AddProduct(new Product("Mouse", "P102", 25, 2));

        // Order 2 (South Africa)
        Address address2 = new Address(
            "15 Long Street",
            "Cape Town",
            "Western Cape",
            "South Africa");

        Customer customer2 = new Customer("Sarah Jones", address2);

        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Keyboard", "P201", 50, 1));
        order2.AddProduct(new Product("Monitor", "P202", 200, 2));

        // Display Order 1
        Console.WriteLine("=================================");
        Console.WriteLine("ORDER 1");
        Console.WriteLine("=================================");

        Console.WriteLine("\nPACKING LABEL");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine("SHIPPING LABEL");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine($"\nTotal Price: ${order1.CalculateTotalCost()}");

        // Display Order 2
        Console.WriteLine("\n=================================");
        Console.WriteLine("ORDER 2");
        Console.WriteLine("=================================");

        Console.WriteLine("\nPACKING LABEL");
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine("SHIPPING LABEL");
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine($"\nTotal Price: ${order2.CalculateTotalCost()}");
    }
}