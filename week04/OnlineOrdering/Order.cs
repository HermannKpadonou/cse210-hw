using System;
using System.Collections.Generic;



public class Order
{
    
    private Customer customer;
    private List<Product> products;

    public Order(Customer customer)
    {
        this.customer = customer;
        products = new List<Product>();
    }
    
    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public decimal CalculateTotal()
    {
        decimal subtotal = 0;
        foreach (var p in products)
        {
            subtotal += p.GetTotalPrice();
        }

        decimal total = 0;
        if (!customer.IsInUSA())
        {
            total = subtotal + 5;
        }
        else
        {
            total = subtotal + 35;
        }
        return total;
    }

    public void DisplayOrderDetails()
    {
        Console.WriteLine("====================================");
        Console.WriteLine($"Customer Name: {customer.GetCustomerInfo().Split(',')[0].Replace("Customer Name: ", "")}");
        Console.WriteLine($"Shipping Address: {customer.GetCustomerInfo().Split("Address: ")[1]}");
        Console.WriteLine("Products:");
        foreach (var product in products)
        {
            Console.WriteLine(product.GetInfoProduct());
        }
        Console.WriteLine($"Total: {CalculateTotal()}");
        Console.WriteLine("====================================");
    }
}
