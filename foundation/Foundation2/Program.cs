using System;

class Program
{
    static void Main(string[] args)
    {
        //Order 1
        Address address1 = new Address("1528 Bezuidenhout St", "Piet Retief", "Mpumalanga", "South Africa");
        Customer customer1 = new Customer("Janet Peters", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("TELEVISION ISTAR 55-inch", "Smart S55GW01-Black", 1500.00, 1));
        order1.AddProduct(new Product("Hair Dryer", "BHD510/00", 76.00, 3));

        //Order 2
        Address address2 = new Address("1631 Telford Ave", "Vryburg", "North West", "South Africa");
        Customer customer2 = new Customer("Roberts Smith", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Samsung Yellow Toner", "Y504S", 100.00, 3));
        order2.AddProduct(new Product("Pure Digital Sport Watch", "NFS7201-G", 20.00, 2));

        //results for Order 1
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: R{order1.CalculateTotalCost():F2}\n");

        //results for Order 2
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: R{order2.CalculateTotalCost():F2}\n");
    }
}
