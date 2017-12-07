using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librarian
{
    public interface ILibraryUser
    {
        void AddBook(Book book);
        void RemoveBook(int id);
        Book BookInfo(int id);
        int BooksCount();
    }
}
