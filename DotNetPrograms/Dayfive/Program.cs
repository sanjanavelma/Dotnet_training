
//     //     FileLogger f=new FileLogger();
//     //     ((ILogger)f).Log();
//     //     ((INotifier)f).Log();
//     // 
//     // Accessing via interface references
//         // IDisposable resource = new ResourceHandler();
//         // resource.Dispose();  // Works

//         // INotifier notifier = new ResourceHandler();
//         // notifier.Log();     // Works

//         // ResourceHandler obj = new ResourceHandler();
//         // obj.Dispose();      // ERROR: not accessible directly
//         // obj.Log();          // ERROR: not accessible directly
using System;
using System.Collections.Generic;
using LibrarySystem;
using LibrarySystem.Items;
using LibrarySystem.Users;
using ItemsAlias = LibrarySystem.Items;

class Program
{
    static void Main()
    {
        Book book = new Book() { Title = "C# Fundamentals", Author = "John Doe", ItemID = 101 };
        Magazine magazine = new Magazine() { Title = "Tech Today", Author = "Jane Doe", ItemID = 201 };

        book.DisplayDetails();
        Console.WriteLine($"Late Fee for 3 days: {book.CalculateLateFee(3)}");
        Console.WriteLine();

        magazine.DisplayDetails();
        Console.WriteLine($"Late Fee for 3 days: {magazine.CalculateLateFee(3)}");
        Console.WriteLine();

        IReservable reservable = book;
        INotifiable notifiable = book;
        reservable.Reserve();
        notifiable.Notify("Please return the book on time.");
        Console.WriteLine("Explicit implementation prevents direct access; only interface references can call them.");
        Console.WriteLine();

        List<LibraryItem> libraryItems = new List<LibraryItem>();
        libraryItems.Add(book);
        libraryItems.Add(magazine);

        foreach (var item in libraryItems)
        {
            item.DisplayDetails();
        }

        Console.WriteLine("Method executed depends on actual object type at runtime, not reference type.");
        Console.WriteLine();

        eBook ebook = new eBook() { Title = "AI Revolution", Author = "Sam Tech", ItemID = 301 };
        Console.WriteLine("Book and Magazine created using namespace alias.");
        Console.WriteLine("1. Nested namespaces organize large projects.");
        Console.WriteLine("2. Aliases make code cleaner and readable.");
        Console.WriteLine();

        LibraryAnalytics.TotalBorrowed = 5;
        LibraryAnalytics.ShowAnalytics();
        Console.WriteLine("Static members store shared system data.");
        Console.WriteLine();

        Member m = new Member() { Name = "Sanjana", Role = UserRole.Member };
        Console.WriteLine($"User Role: {m.Role}");
        Console.WriteLine($"Item Status: {ItemStatus.Borrowed}");
        Console.WriteLine("Enums prevent invalid values and improve readability.");
        Console.WriteLine();

        m.SendRoleBasedNotification();

        Member admin = new Member() { Role = UserRole.Admin };
        admin.SendRoleBasedNotification();

        ebook.DisplayDetails();
        ebook.Download();
    }
}
