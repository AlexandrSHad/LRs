using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librarian
{
    class Program
    {
        static void Main(string[] args)
        {
            var libuser = new LibraryUser();

            libuser.InitBooks();

            Console.WriteLine(libuser.BooksCount());

            libuser.RemoveBook(2);

            libuser.AddBook(new Book(10, "Book 10", "Author 10", 1050));

            libuser.AddBook(new Book(11, "Book 11", "Author 11", 1150));

            Console.WriteLine();
            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }
}
