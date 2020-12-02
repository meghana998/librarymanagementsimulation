using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddNewBook_API.Repository
{
    public interface IAddNewBook
    {
     
        public bool AddNewBook(Book book);
        public IEnumerable<Book> DisplayAllBooks();
    }
}
