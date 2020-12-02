using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booksearch_API.Repository
{
    
    public class GetBookDetails:IGetBookDetails
    {
        librarymanagementContext b1 = new librarymanagementContext();
        public GetBookDetails(librarymanagementContext _context) 
        {
            b1 = _context;
        }
        public Book GetBookInfo(int id)
        {
            
            var bok = b1.Book.SingleOrDefault(x => x.Bookid == id);
            return bok;
        }
        public IEnumerable<Book> DisplayAllBooks()
        {
            var booklist = from book in b1.Book select book;
            return booklist.ToList();
        }

    }
}
