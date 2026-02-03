using System;

class Program
{
    static void Main()
    {
        BikeStoresServices service = new BikeStoresServices();

        service.customers.Add(new Customers
        {
            customer_id = 1,
            first_name = "Sanjana",
            last_name = "Velma",
            city = "Bangalore"
        });

        service.orders.Add(new Orders
        {
            order_id = 101,
            customer_id = 1,
            store_id = 1,
            staff_id = 1,
            order_time = DateTime.Now
        });

        service.order_items.Add(new Order_item
        {
            order_id = 101,
            item_id = 1,
            product_id = 1,
            quantity = 2,
            list_price = 50000,
            discount = 0.1m
        });

        Console.WriteLine("Orders for customer 1:");
        foreach (var o in service.GetOrdersByCustomers(1))
        {
            Console.WriteLine($"Order ID: {o.order_id}");
        }

        Console.WriteLine("\nOrder Total:");
        Console.WriteLine(service.GetOrderTotal(101));
    }
}
