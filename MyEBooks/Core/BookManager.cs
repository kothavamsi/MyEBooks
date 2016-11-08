using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyEBooks.Models;

namespace MyEBooks.Core
{
    public class BookManager
    {
        public IList<Book> FindBookByKeyword(string keyword)
        {
            IList<Book> books = new List<Book>();
            return books;
        }
    }
}