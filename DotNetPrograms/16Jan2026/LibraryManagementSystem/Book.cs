using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
public interface IBook
{
    
}
public class Book
    {
        public int Id{get; set;}
        public string Title{get; set;}
        public string Author{get; set;}
        public string Category{get; set;}
        public int Price{get; set;}
    }
public interface ILibrarySystem
{
    void AddBook(Book book, int quantity);
    void RemoveBook(Book book, int quantity);
    double CalculateTotal();
    
}
public class LibrarySystem
{
    
}