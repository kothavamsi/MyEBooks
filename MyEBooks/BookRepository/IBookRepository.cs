using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyEBooks.Models;

namespace MyEBooks.Core
{
    public interface IBookRepository
    {
        IList<Book> GetBooksByKeyword(string keyword);
        IList<Book> GetAllBooks();
        IList<Book> GetBooksByCategory(string categoryName);
    }
}