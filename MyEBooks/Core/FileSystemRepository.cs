using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyEBooks.Models;

namespace MyEBooks.Core
{
    public class FileSystemRepository :IBookRepository
    {
        public IList<Book> GetBooksByKeyword(string keyword)
        {
            throw new NotImplementedException();
        }

        public IList<Book> GetAllBooks()
        {
            throw new NotImplementedException();
        }

        public IList<Book> GetBooksByCategory(Models.BookCategory bookCategory)
        {
            throw new NotImplementedException();
        }
    }
}