using System;

// Entry point for the program that demonstrates the functionality.
class Program
{
    static void Main(string[] args)
    {
        // Step 1: Creating products for the orders.
        Product product1 = new Product("Iphone 16", "P001", 900.00, 1);
        Product product2 = new Product("Television", "P002", 255.00, 2);
        Product product3 = new Product("Laptop", "P003", 800.00, 1);
        Product product4 = new Product("Cap", "P004", 40.00, 2);

        // Step 2: Creating customers with their addresses.
        Address address1 = new Address("123 Elm St", "Springfield", "IL", "USA");
        Customer customer1 = new Customer("Lee Mary", address1);

        Address address2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Joe Mac", address2);

        // Step 3: Creating orders and add products to them.
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        // Step 4: Displaying details for Order 1.
        Console.WriteLine("Order 1 Details:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.CalculateTotalCost():0.00}\n");

        // Step 5: Displaying details for Order 2.
        Console.WriteLine("Order 2 Details:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.CalculateTotalCost():0.00}");
    }
}
