using System;

class Program
{
    static void Main(string[] args)
    {
        // --------------------------------------------------
        // Order 1: US Customer
        // --------------------------------------------------
        Address usAddress = new Address("123 Main Street", "Springfield", "IL", "USA");
        Customer usCustomer = new Customer("John Doe", usAddress);

        Order order1 = new Order(usCustomer);
        order1.AddProduct(new Product("Laptop", "P101", 1200.00, 1));
        order1.AddProduct(new Product("Mouse", "P202", 25.50, 2));

        Console.WriteLine("--------------------- Order #1 ---------------------");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost():F2}\n");


        // --------------------------------------------------
        // Order 2: International Customer
        // --------------------------------------------------
        Address intlAddress = new Address("456 International Blvd", "Toronto", "Ontario", "Canada");
        Customer intlCustomer = new Customer("Jane Smith", intlAddress);

        Order order2 = new Order(intlCustomer);
        order2.AddProduct(new Product("Keyboard", "P303", 75.00, 1));
        order2.AddProduct(new Product("Monitor", "P404", 300.00, 1));
        order2.AddProduct(new Product("USB Hub", "P505", 15.00, 3));

        Console.WriteLine("--------------------- Order #2 ---------------------");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost():F2}");
        Console.WriteLine("--------------------------------------------------");
    }
}