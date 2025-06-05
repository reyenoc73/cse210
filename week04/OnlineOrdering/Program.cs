using System;

class Program
{
    static void Main()
    {
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("Alice Smith", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "L1001", 999.99, 1));
        order1.AddProduct(new Product("Mouse", "M2001", 25.50, 2));

        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Bob Johnson", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Monitor", "MN3001", 199.99, 1));
        order2.AddProduct(new Product("Keyboard", "KB4001", 49.99, 1));

        foreach (var order in new[] { order1, order2 })
        {
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Price: ${order.GetTotalCost():0.00}\n");
        }
    }
}