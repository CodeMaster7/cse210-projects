using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Online Ordering System Demo ===\n");

        // Create first customer (lives in USA)
        Address address1 = new Address("123 Main St", "Rexburg", "ID", "USA");
        Customer customer1 = new Customer("John Smith", address1);

        // Create first order for customer1
        Order order1 = new Order(customer1);

        // Add products to first order
        Product laptop = new Product("Gaming Laptop", "TECH-001", 899.99, 1);
        Product mouse = new Product("Wireless Mouse", "TECH-002", 29.99, 2);
        Product keyboard = new Product("Mechanical Keyboard", "TECH-003", 149.99, 1);

        order1.AddProduct(laptop);
        order1.AddProduct(mouse);
        order1.AddProduct(keyboard);

        // Create second customer (lives outside USA)
        Address address2 = new Address("456 Oak Avenue", "Toronto", "Ontario", "Canada");
        Customer customer2 = new Customer("Sarah Johnson", address2);

        // Create second order for customer2
        Order order2 = new Order(customer2);

        // Add products to second order
        Product headphones = new Product("Noise-Canceling Headphones", "AUDIO-001", 199.99, 1);
        Product speakers = new Product("Bluetooth Speakers", "AUDIO-002", 79.99, 2);

        order2.AddProduct(headphones);
        order2.AddProduct(speakers);

        // Display information for first order
        Console.WriteLine("=== ORDER 1 ===");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("--- COST BREAKDOWN ---");
        Console.WriteLine($"Products Subtotal: ${order1.GetProductsSubtotal():F2}");
        Console.WriteLine($"Shipping Cost:     ${order1.GetShippingCost():F2}");
        Console.WriteLine($"                   --------");
        Console.WriteLine($"TOTAL COST:        ${order1.CalculateTotalCost():F2}");
        Console.WriteLine();

        // Display information for second order
        Console.WriteLine("=== ORDER 2 ===");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("--- COST BREAKDOWN ---");
        Console.WriteLine($"Products Subtotal: ${order2.GetProductsSubtotal():F2}");
        Console.WriteLine($"Shipping Cost:     ${order2.GetShippingCost():F2}");
        Console.WriteLine($"                   --------");
        Console.WriteLine($"TOTAL COST:        ${order2.CalculateTotalCost():F2}");
        Console.WriteLine();

        // Show the difference in shipping costs
        Console.WriteLine("=== SHIPPING COST COMPARISON ===");
        Console.WriteLine($"Customer 1 (USA):    ${order1.GetShippingCost():F2} shipping");
        Console.WriteLine($"Customer 2 (Canada): ${order2.GetShippingCost():F2} shipping");
    }
}