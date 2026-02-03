using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
public class RealEstateListing
    {
        public int ID{get; set;}
        public string Title{get; set;}
        public string Description{get; set;}
        public int Price{get; set;}
        public string Location{get; set;}
    }
    public class RealEstateApp
    {
        private List<RealEstateListing> listings = new List<RealEstateListing>();
        public void AddListing(RealEstateListing listing)
        {
            listings.Add(listing);
        }
        public void RemoveListing(int listingID)
        {
            var listing = listings.FirstOrDefault(l => l.ID == listingID);
            if (listing != null)
            {
                listings.Remove(listing);
            }
        }
        public void UpdateListing(RealEstateListing updatedlisting)
        {
            var listing = listings.FirstOrDefault(l => l.ID == updatedlisting.ID);
            if (listing != null)
        {
            listing.Title = updatedlisting.Title;
            listing.Description = updatedlisting.Description;
            listing.Price = updatedlisting.Price;
            listing.Location = updatedlisting.Location;
        }
        } 
        public List<RealEstateListing> GetListing()
        {
            return listings;
        }
        public List<RealEstateListing> GetListingByLocation(string location)
        {
            return listings
                .Where(l => l.Location.Equals(location, StringComparison.OrdinalIgnoreCase)).ToList();
        }
        public List<RealEstateListing> GetListingByPriceRange(int minPrice, int maxPrice)
        {
            return listings
                .Where(l => l.Price >= minPrice && l.Price <= maxPrice).ToList();
        }
    }
