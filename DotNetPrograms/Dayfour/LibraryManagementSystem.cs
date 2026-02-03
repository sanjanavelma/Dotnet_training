using System;
public class LibraryManagementSystem
    {
        private Dictionary<int, string> Books = new Dictionary<int, string>();
        public string this[int Bookid]
    {
        get
        {
            if (Books.ContainsKey(Bookid))
            {
                return Books[Bookid];
            }
            else
            {
                return "Book not Found";
            }
        }
        set
        {
            Books[Bookid] = value;
        }
    }
    public string this[string title]
    {
        get
        {
            foreach(var item in Books)
            {
                if (item.Value == title)
                {
                    return item.Value;
                }
            }
            return "Book is not Found";
        }
    }
    }
