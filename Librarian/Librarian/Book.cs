using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librarian
{
    public class Book
    {
        public int Id { get; set; }
        public string Caption { get; set; }
        public string Author { get; set; }
        public int PageCount { get; set; }

        public Book(int id, string caption, string author, int pageCount)
        {
            this.Id = id;
            this.Caption = caption;
            this.Author = author;
            this.PageCount = pageCount;
        }
    }
}
