using System;
using System.Collections.Generic;

#nullable disable

namespace AuthorizationService
{
    public partial class Book
    {
        public int Bookid { get; set; }
        public string Bookname { get; set; }
        public string AuthorName { get; set; }
        public int BookEdition { get; set; }
    }
}
