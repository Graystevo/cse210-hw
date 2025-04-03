using System;
using System.Collections.Generic;

namespace OrderProcessingApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Address address1 = new Address("123 Main St", "New York", "NY", "USA");
            Address address2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");

            Customer customer1 = new Customer("John Doe", address1);
            Customer customer2 = new Customer("Jane Smith", address2);

            Product product1 = new Product("Laptop", "P001", 999.99f, 1);
            Product product2 = new Product("Mouse", "P002", 19.99f, 2);
            Product product3 = new Product("Keyboard", "P003", 49.99f, 1);

            Product product4 = new Product("Monitor", "P004", 199.99f, 2);
            Product product5 = new Product("USB Cable", "P005", 9.99f, 3);

            List<Product> order1Products = new List<Product> { product1, product2, product3 };
            List<Product> order2Products = new List<Product> { product4, product5 };

            Order order1 = new Order(customer1, order1Products);
            Order order2 = new Order(customer2, order2Products);

            Console.WriteLine(order1.GetPackingLabel());
            Console.WriteLine(order1.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost():0.00}\n");

            Console.WriteLine(order2.GetPackingLabel());
            Console.WriteLine(order2.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost():0.00}\n");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
