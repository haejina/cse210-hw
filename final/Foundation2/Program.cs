using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Get customer details from the user
        Console.WriteLine("Enter Customer Name:");
        string customerName = Console.ReadLine();

        Console.WriteLine("Enter Street Address:");
        string streetAddress = Console.ReadLine();

        Console.WriteLine("Enter City:");
        string city = Console.ReadLine();

        Console.WriteLine("Enter State/Province:");
        string stateProvince = Console.ReadLine();

        Console.WriteLine("Enter Country:");
        string country = Console.ReadLine();

        Address customerAddress = new Address(streetAddress, city, stateProvince, country);
        Customer customer = new Customer(customerName, customerAddress);

        // Get order details from the user
        Order order = new Order(customer);

        Console.WriteLine("How many products do you want to add to the order?");
        int numberOfProducts = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfProducts; i++)
        {
            Console.WriteLine($"Enter Product {i + 1} Name:");
            string productName = Console.ReadLine();

            Console.WriteLine($"Enter Product {i + 1} ID:");
            string productId = Console.ReadLine();

            Console.WriteLine($"Enter Product {i + 1} Price:");
            double productPrice = double.Parse(Console.ReadLine());

            Console.WriteLine($"Enter Product {i + 1} Quantity:");
            int productQuantity = int.Parse(Console.ReadLine());

            Product product = new Product(productName, productId, productPrice, productQuantity);
            order.AddProduct(product);
        }

        // Display packing label and total price for the order
        Console.WriteLine("\nOrder Packing Label:");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine($"Total Price: ${order.CalculateTotalPrice():F2}\n");
    }
}
