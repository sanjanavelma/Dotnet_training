using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        RealEstateApp app = new RealEstateApp();
        app.AddListing(new RealEstateListing
        {
            ID = 1,
            Title = "2BHK Apartment",
            Description = "Near city center",
            Price = 5000000,
            Location = "Bangalore"
        });
        app.AddListing(new RealEstateListing
        {
            ID = 2,
            Title = "1BHK Flat",
            Description = "HITECH City",
            Price = 45000,
            Location = "Hyderabad"
        });
        Console.WriteLine("\nListings in Hyderabad:");
        foreach (var l in app.GetListingByLocation("Hyderabad"))
        {
            Console.WriteLine($"{l.Title} - ₹{l.Price}");
        }
        Console.WriteLine("\nListings between 4M and 10M:");
        foreach (var l in app.GetListingByPriceRange(4000000, 10000000))
        {
            Console.WriteLine($"{l.Title} - ₹{l.Price}");
        }

    }
}