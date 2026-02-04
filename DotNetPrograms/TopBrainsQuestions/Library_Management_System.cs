using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static List<dynamic> books = new List<dynamic>();
    static int idCounter = 1;
    static void Main(string[] args)
    {
        while(true)
        {
            Console.WriteLine("\n===== Book Library Management System =====");
            Console.WriteLine("1. Admin");
            Console.WriteLine("2. User");
            Console.WriteLine("3. Exit");
            Console.WriteLine("Select Role: ");

            int choice = int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    AdminMenu();
                    break;
                case 2:
                    UserMenu();
                    break;
                case 3:
                    Console.WriteLine("Exiting system...");
                    return;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }
    static void AdminMenu()
    {
        while (true)
        {
            Console.WriteLine("\n----- ADMIN PANEL -----");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Update Book");
            Console.WriteLine("3. Delete Book");
            Console.WriteLine("4. View All Books");
            Console.WriteLine("5. Back");
            Console.WriteLine("Choice: ");

            int choice = int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    AddBook(); 
                    break;
                case 2:
                    UpdateBook();
                    break;
                case 3:
                    DeleteBook();
                    break;
                case 4:
                    ViewBooks();
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }
    static void UserMenu()
    {
        while(true)
        {
            Console.WriteLine("\n-----User Panel -----");
            Console.WriteLine("1. Browse Books");
            Console.WriteLine("2. Search Book by Name");
            Console.WriteLine("3. Serach Book by Publisher");
            Console.WriteLine("4. View Highest Price Book");
            Console.WriteLine("5. View Lowest Price Book");
            Console.WriteLine("6. Back");
            Console.Write("Choice: ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    ViewBooks();
                    break;
                case 2:
                    SearchByName();
                    break;
                case 3:
                    SearchByPublisher();
                    break;
                case 4:
                    HighestPriceBook();
                    break;
                case 5:
                    LowestPriceBook();
                    break;
                case 6:
                    return;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }
    static void AddBook()
    {
        dynamic book = new System.Dynamic.ExpandoObject();
        book.Id = idCounter++;
        Console.Write("Book Name: ");
        book.Name = Console.ReadLine();
        Console.Write("Publisher: ");
        book.Publisher = Console.ReadLine();
        Console.Write("Price: ");
        book.Price = double.Parse(Console.ReadLine());
        books.Add(book);
        Console.WriteLine("Book Added Successfully!");
    }
    static void UpdateBook()
    {
        Console.WriteLine("Enter Book ID to Update: ");
        int id = int.Parse(Console.ReadLine());
        var book = books.FirstOrDefault(b => b.Id == id);
        if(book == null)
        {
            Console.WriteLine("Book not found!");
            return;
        }
        Console.Write("New Name: ");
        book.Name = Console.ReadLine();
        Console.WriteLine("New Publisher: ");
        book.Publisher = Console.ReadLine();
        Console.WriteLine("New Price: ");
        book.Price = double.Parse(Console.ReadLine());
        Console.WriteLine("Book Updated Successfully!");
    }
    static void DeleteBook()
    {
        Console.WriteLine("Enter Book ID to delete: ");
        int id = int.Parse(Console.ReadLine());
        var book = books.FirstOrDefault(b => b.Id == id);
        if (book == null)
        {
            Console.WriteLine("Book not found!");
            return;
        }
        books.Remove(book);
        Console.WriteLine("Book Deleted Successfully");
    }
    static void ViewBooks()
    {
        Console.WriteLine("\n--- BOOK LIST ---");

        if (books.Count == 0)
        {
            Console.WriteLine("No books available.");
            return;
        }

        foreach (var b in books)
        {
            Console.WriteLine($"ID: {b.Id} | Name: {b.Name} | Publisher: {b.Publisher} | Price: {b.Price}");
        }
    }

    static void SearchByName()
    {
        Console.Write("Enter book name: ");
        string name = Console.ReadLine().ToLower();

        var result = books.Where(b => b.Name.ToLower().Contains(name)).ToList();

        if (result.Count == 0)
        {
            Console.WriteLine("No books found.");
            return;
        }

        foreach (var b in result)
        {
            Console.WriteLine($"ID: {b.Id} | Name: {b.Name} | Publisher: {b.Publisher} | Price: {b.Price}");
        }
    }

    static void SearchByPublisher()
    {
        Console.Write("Enter publisher name: ");
        string pub = Console.ReadLine().ToLower();

        var result = books.Where(b => b.Publisher.ToLower().Contains(pub)).ToList();

        if (result.Count == 0)
        {
            Console.WriteLine("No books found.");
            return;
        }

        foreach (var b in result)
        {
            Console.WriteLine($"ID: {b.Id} | Name: {b.Name} | Publisher: {b.Publisher} | Price: {b.Price}");
        }
    }

    static void HighestPriceBook()
    {
        if (books.Count == 0)
        {
            Console.WriteLine("No books available.");
            return;
        }

        var book = books.OrderByDescending(b => b.Price).First();
        Console.WriteLine("\nHighest Price Book:");
        Console.WriteLine($"ID: {book.Id} | Name: {book.Name} | Publisher: {book.Publisher} | Price: {book.Price}");
    }

    static void LowestPriceBook()
    {
        if (books.Count == 0)
        {
            Console.WriteLine("No books available.");
            return;
        }

        var book = books.OrderBy(b => b.Price).First();
        Console.WriteLine("\nLowest Price Book:");
        Console.WriteLine($"ID: {book.Id} | Name: {book.Name} | Publisher: {book.Publisher} | Price: {book.Price}");
    }
}
