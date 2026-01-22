using System;
using System.Collections.Generic;
using System.Linq;

public class Customers
{
    public int customer_id { get; set; }
    public string first_name { get; set; } = string.Empty;
    public string last_name { get; set; } = string.Empty;
    public string phone { get; set; } = string.Empty;
    public string street { get; set; } = string.Empty;
    public string city { get; set; } = string.Empty;
    public string state { get; set; } = string.Empty;
    public string zip_code { get; set; } = string.Empty;
}

public class Staffs
{
    public int staff_id { get; set; }
    public string first_name { get; set; } = string.Empty;
    public string last_name { get; set; } = string.Empty;
    public string email { get; set; } = string.Empty;
    public string phone { get; set; } = string.Empty;
    public bool active { get; set; }
    public int store_id { get; set; }
    public int manager_id { get; set; }
}

public class Orders
{
    public int order_id { get; set; }
    public int customer_id { get; set; }
    public int order_status { get; set; }
    public DateTime order_time { get; set; }
    public DateTime required_date { get; set; }
    public DateTime shipped_date { get; set; }
    public int store_id { get; set; }
    public int staff_id { get; set; }
}

public class Stores
{
    public int store_id { get; set; }
    public string store_name { get; set; } = string.Empty;
    public string phone { get; set; } = string.Empty;
    public string email { get; set; } = string.Empty;
    public string street { get; set; } = string.Empty;
    public string city { get; set; } = string.Empty;
    public string state { get; set; } = string.Empty;
    public string zip_code { get; set; } = string.Empty;
}

public class Order_item
{
    public int order_id { get; set; }
    public int item_id { get; set; }
    public int product_id { get; set; }
    public int quantity { get; set; }
    public decimal list_price { get; set; }
    public decimal discount { get; set; }
}

public class BikeStoresServices
{
    public List<Customers> customers = new();
    public List<Staffs> staffs = new();
    public List<Orders> orders = new();
    public List<Stores> stores = new();
    public List<Order_item> order_items = new();

    public List<Orders> GetOrdersByCustomers(int customerId)
    {
        return orders
            .Where(o => o.customer_id == customerId)
            .ToList();
    }

    public decimal GetOrderTotal(int orderId)
    {
        return order_items
            .Where(oi => oi.order_id == orderId)
            .Sum(oi => oi.quantity * oi.list_price * (1 - oi.discount));
    }

    public List<Orders> GetOrdersByStore(int storeId)
    {
        return orders
            .Where(o => o.store_id == storeId)
            .ToList();
    }
}
