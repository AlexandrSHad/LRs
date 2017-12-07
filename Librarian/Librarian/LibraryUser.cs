using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librarian
{
    public class LibraryUser : ILibraryUser
    {
        private Book[] bookList;

        public int Id { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public string PhoneNumber { get; set; }
        public int BookLimit { get; }

        public LibraryUser()
        {
            this.Id = 0;
            this.FirstName = "Anonymous";
            this.LastName = "Anonymous";
            this.BookLimit = 10;

            bookList = new Book[this.BookLimit];
        }

        public LibraryUser(int id, string firstName, string lastName, int bookLimit)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BookLimit = bookLimit;

            bookList = new Book[this.BookLimit];
        }

        public void InitBooks()
        {
            bookList = new Book[]
            {
                new Book(1, "Book 1", "Author 1", 150),
                new Book(2, "Book 2", "Author 2", 250),
                new Book(3, "Book 3", "Author 3", 350)
            };
        }

        public void AddBook(Book book)
        {
            int idx = -1;
            for (int i = 0; i < bookList.Length; i++)
            {
                if (bookList[i] == null)
                {
                    idx = i;
                    break;
                }
            }

            if (idx == -1)
            {
                idx = bookList.Length;
                var tmp = new Book[bookList.Length * 2];

                for (int i = 0; i < bookList.Length; i++)
                {
                    tmp[i] = bookList[i];
                }

                bookList = tmp;
            }

            bookList[idx] = book;
        }

        public Book BookInfo(int id)
        {
            for (int i = 0; i < bookList.Length; i++)
            {
                if (bookList[i].Id == id)
                {
                    return bookList[i];
                }
            }

            return null;
        }

        public int BooksCount()
        {
            return bookList.Length;
        }

        public void RemoveBook(int id)
        {
            int idx;
            for (idx = 0; idx < bookList.Length; idx++)
            {
                if (bookList[idx].Id == id)
                {
                    break;
                }
            }

            bookList[idx] = null;
        }
    }
}
