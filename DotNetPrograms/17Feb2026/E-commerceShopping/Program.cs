using System;
using System.Collections.Generic;
using System.Linq;
class Electronics : Product { }
class Program
{
    static void Main()
    {
        ShoppingCart<Electronics> cart = new ShoppingCart<Electronics>();
        cart.AddToCart(new Electronics{Id = 1, Name = "Laptop", Price = 999.99}, 1);
        cart.AddToCart(new Electronics{Id = 2, Name = "Mouse", Price = 29.99}, 2);

        double total = cart.CalculateTotal((product, price) => price > 100 ? price * 0.9 : price);
        Console.WriteLine($"Total: {total:F2}");

        var top = cart.GetTopExpensiveItems(2);
        Console.WriteLine(top[0].Name);
        Console.WriteLine(top[1].Name);
    }
}