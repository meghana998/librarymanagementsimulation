using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddNewBook_API.Repository
{
    public class AddNewBook : IAddNewBook
    {
        readonly librarymanagementContext b1 = new librarymanagementContext();
        public AddNewBook(librarymanagementContext _context)
        {
            b1 = _context;
        }
        

        bool IAddNewBook.AddNewBook(Book book)
        {
            if (book.AuthorName != null && book.Bookname != null)
            {
                b1.Book.Add(book);
                b1.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public IEnumerable<Book> DisplayAllBooks()
        {
            var booklist = from book in b1.Book select book;
            return booklist.ToList();
        }
    }
}
