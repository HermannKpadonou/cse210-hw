using System;


class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Springfield", "IL", "62701", "USA");
        Address address2 = new Address("Garden Street", "Abidjan", "Lagunes", "01 BP 1234", "Ivory Coast");

        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Marie Kouassi", address2);

        Product product1 = new Product("Canned Wheat", 4.99m, 6, "P001");
        Product product2 = new Product("Powdered Milk", 8.50m, 3, "P002");
        Product product3 = new Product("Honey", 12.75m, 2, "P003");
        Product product4 = new Product("White Rice", 15.25m, 4, "P004");
        Product product5 = new Product("Red Beans", 7.80m, 5, "P005");
        Product product6 = new Product("Vegetable Oil", 6.45m, 2, "P006");
        Product product7 = new Product("Sugar", 5.20m, 3, "P007");
        Product product8 = new Product("Pasta", 3.95m, 8, "P008");

        Order order = new Order(customer1);
        order.AddProduct(product1);
        order.AddProduct(product2);
        order.AddProduct(product3);
        order.DisplayOrderDetails();

        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product1);
        order2.DisplayOrderDetails();
    }
}