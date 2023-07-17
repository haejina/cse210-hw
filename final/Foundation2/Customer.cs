using System;
using System.Collections.Generic;
class Customer
{
    private string name;
    private Address address;

    public string GetName()
    {
        return name;
    }

    public void SetName(string name)
    {
        this.name = name;
    }

    public Address GetAddress()
    {
        return address;
    }

    public void SetAddress(Address address)
    {
        this.address = address;
    }

    public bool IsInUSA()
    {
        return address.GetCountry().Equals("USA", StringComparison.OrdinalIgnoreCase);
    }

    public Customer(string name, Address address)
    {
        SetName(name);
        SetAddress(address);
    }
}
