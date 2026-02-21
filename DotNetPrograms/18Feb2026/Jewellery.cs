using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
public class Jewellery
{
    public string Id { get; set; }
    public string Type { get; set; }
    public string Material { get; set; }
    public int Price { get; set; }
}

public class JewelleryUtility
{
    public static void GetJewelleryDetails(Jewellery j)
    {
        // WRITE YOUR CODE HERE
        Console.WriteLine($"Details: {j.Id} {j.Type} {j.Price}");
    }

    public static void UpdateJewelleryPrice(Jewellery j, int newPrice)
    {
        // WRITE YOUR CODE HERE
        j.Price = newPrice;
        Console.WriteLine($"Updated Price: {newPrice}");
    }
}
