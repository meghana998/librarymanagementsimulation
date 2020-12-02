using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc_Client.Models
{
    public class BookViewModel
    {
        [Key]
        [Display(Name = "Book id")]
        public int Bookid { get; set; }
        [Display(Name = "Author Name")]
        public string AuthorName { get; set; }
        [Display(Name = "Book Name")]
        public string Bookname { get; set; }
        [Display(Name = "Book Edition")]
        public int BookEdition { get; set; }
    }
}
