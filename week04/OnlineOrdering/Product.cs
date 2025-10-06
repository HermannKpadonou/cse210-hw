using System;

public class Product
{
    private string name;
    private decimal price;
    private int quantity;
    private string id;

    public Product(string name, decimal price, int quantity, string id)
    {
        this.name = name;
        this.price = price;
        this.quantity = quantity;
        this.id = id;
    }

    public decimal GetTotalPrice()
    {
        return price * quantity;
    }

    public string GetInfoProduct()
    {
        return $"Product ID: {id},{name}, {price},{quantity}";
    }
}