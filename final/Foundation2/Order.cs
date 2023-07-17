using System;
using System.Collections.Generic;

class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(Customer customer)
    {
        products = new List<Product>();
        this.customer = customer;
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double CalculateTotalPrice()
    {
        double totalPrice = 0;
        foreach (Product product in products)
        {
            totalPrice += product.GetPrice() * product.GetQuantity();
        }

        if (customer.IsInUSA())
        {
            totalPrice += 5; // Shipping cost for USA customers
        }
        else
        {
            totalPrice += 35; // Shipping cost for international customers
        }

        return totalPrice;
    }

    public string GetPackingLabel()
    {
        string label = $"Customer: {customer.GetName()}\nShipping Address: {customer.GetAddress().GetFullAddress()}\n\nProducts:\n";
        foreach (Product product in products)
        {
            label += $"- {product.GetName()} (Qty: {product.GetQuantity()})\n";
        }
        return label;
    }
}