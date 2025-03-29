using System;

class Program
{
    static void Main(string[] args)
    {
        //Customer #1
        Address address1 = new Address("123 Lehi st","Salt Lake","UT","USA");
        Customer customer1 = new Customer("Lauren Ashcroft", address1);

        Product product1 = new Product("Laptop", 1000.50, 101, 1);
        Product product2 = new Product("Keyboard", 49.99, 102, 1);
        Product product3 = new Product("Mouse", 9.99, 103, 2);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():f2}");
        Console.WriteLine("\n-----------------------------------\n");

        //Customer #2

        Address address2 = new Address("Calle 137 #85-76","Bogota","Cundinamarca","Colombia");
        Customer customer2 = new Customer("Cristian Perez", address2);

        Product product4 = new Product("Laptop", 1000.50, 101, 1);
        Product product5 = new Product("Keyboard", 49.99, 102, 1);
        Product product6 = new Product("Mouse", 9.99, 103, 2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():f2}");
    }

}