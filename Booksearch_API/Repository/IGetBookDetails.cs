using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booksearch_API.Repository
{
    public interface IGetBookDetails
    {
        public Book GetBookInfo(int id);
        public IEnumerable<Book> DisplayAllBooks();
    }
}
