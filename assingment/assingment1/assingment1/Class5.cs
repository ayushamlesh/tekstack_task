using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace assingment1
{
    internal class Class5
    {
        enum BookType
        { 
          Magazine,
          Novel,
          ReferenceBook,
          Miscellaneous
        }
        struct Book
        {
            public int bookId;
            public string title;
            public double price;
            public BookType bookType;
            public void AcceptDetails()
            {
                Console.WriteLine("Enter Book id:");
                bookId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Book Title: ");
                title = Console.ReadLine();
                Console.WriteLine("Enter Book Price: ");
                price = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Book Type (0 - Magazine, 1 - Novel, 2 - ReferenceBook, 3 - Miscellaneous): ");
                bookType = (BookType)Convert.ToInt32(Console.ReadLine());
            }
            public void DisplayDetails()
            {
                Console.WriteLine("Book Id: " + bookId);
                Console.WriteLine("Book Title: " + title);
                Console.WriteLine("Book Price: " + price);
                Console.WriteLine("Book Type: " + bookType);
            }
        }
       
        static void Main(string[] args)
        {
             Book b = new Book();
            b.AcceptDetails();
            b.DisplayDetails();
            Console.ReadLine();
        }
    }
}
