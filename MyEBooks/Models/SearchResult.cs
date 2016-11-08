using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyEBooks.Models
{
    public class SearchResult
    {
        public string SearchKeyword { get; set; }
        public IList<Book> Books { get; set; }
    }
}