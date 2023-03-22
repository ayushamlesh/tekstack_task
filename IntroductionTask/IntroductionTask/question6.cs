using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionTask
{
    internal class question6
    {
        struct book
        {
            public int bookId;
            public string title;
            public int price;
        }
        public enum bookType { Magzine, Novel, ReferenceBook, Miscellaneous };

        static void Main(string[] args)
        {
            book obj =new book();
            

            Console.WriteLine("Enter the id: ");
            obj.bookId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter book titel:\t");
            obj.title= Console.ReadLine();
            Console.WriteLine("Enter the price: ");
            obj.bookId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(obj.bookId);


        }
    }
}
