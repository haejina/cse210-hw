using System;
using System.Collections.Generic;


class Address
{
    private string streetAddress;
    private string city;
    private string stateProvince;
    private string country;

    public string GetStreetAddress()
    {
        return streetAddress;
    }

    public void SetStreetAddress(string streetAddress)
    {
        this.streetAddress = streetAddress;
    }

    public string GetCity()
    {
        return city;
    }

    public void SetCity(string city)
    {
        this.city = city;
    }

    public string GetStateProvince()
    {
        return stateProvince;
    }

    public void SetStateProvince(string stateProvince)
    {
        this.stateProvince = stateProvince;
    }

    public string GetCountry()
    {
        return country;
    }

    public void SetCountry(string country)
    {
        this.country = country;
    }

    public Address(string streetAddress, string city, string stateProvince, string country)
    {
        SetStreetAddress(streetAddress);
        SetCity(city);
        SetStateProvince(stateProvince);
        SetCountry(country);
    }

    public string GetFullAddress()
    {
        return $"{GetStreetAddress()}, {GetCity()}, {GetStateProvince()}, {GetCountry()}";
    }
}




