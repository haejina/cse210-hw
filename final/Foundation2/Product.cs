using System;
using System.Collections.Generic;

class Product
{
    private string name;
    private string productId;
    private double price;
    private int quantity;

    public string GetName()
    {
        return name;
    }

    public void SetName(string name)
    {
        this.name = name;
    }

    public string GetProductId()
    {
        return productId;
    }

    public void SetProductId(string productId)
    {
        this.productId = productId;
    }

    public double GetPrice()
    {
        return price;
    }

    public void SetPrice(double price)
    {
        this.price = price;
    }

    public int GetQuantity()
    {
        return quantity;
    }

    public void SetQuantity(int quantity)
    {
        this.quantity = quantity;
    }

    public Product(string name, string productId, double price, int quantity)
    {
        SetName(name);
        SetProductId(productId);
        SetPrice(price);
        SetQuantity(quantity);
    }
}