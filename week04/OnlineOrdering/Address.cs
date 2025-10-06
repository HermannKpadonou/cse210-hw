using System;


public class Address
{
    private string street;
    private string city;
    private string state;
    private string zipCode;
    private string country;

    public Address(string street, string city, string state, string zipCode, string country)
    {
        this.street = street;
        this.city = city;
        this.state = state;
        this.zipCode = zipCode;
        this.country = country;
    }

    public bool IsInUSA()
    {
        return country.ToLower() == "usa";
    }

    public string GetFullAddress()
    {
        return $"{street}, {city}, {state} {zipCode}, {country}";
    }
}