using System;

namespace BookStoreApplication
{
    public class BookUtility
    {
        private Book _b;

        public BookUtility(Book b)
        {
            // TODO: Assign book object
            _b = b;
        }

        public void GetBookDetails()
        {
            // TODO:
            // Print format:
            // Details: <BookId> <Title> <Price> <Stock>
            Console.WriteLine($"Details: {_b.Id} {_b.Title} {_b.Price} {_b.Stock}");
        }

        public void UpdateBookPrice(int newPrice)
        {
            // TODO:
            // Validate new price
            // Update price
            // Print: Updated Price: <newPrice>
            _b.Price = newPrice;
        Console.WriteLine("Updated Price: " + _b.Price);
        }

        public void UpdateBookStock(int newStock)
        {
            // TODO:
            // Validate new stock
            // Update stock
            // Print: Updated Stock: <newStock>
            _b.Stock = newStock;
            Console.WriteLine("Upadated Stock: " + _b.Stock);
        }
    }
}
