using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyEBooks.Models;

namespace MyEBooks.Core
{
    public class FileSystemRepository : IBookRepository
    {
        public IList<Book> GetBooksByKeyword(string keyword)
        {
            IList<Book> books = new List<Book>();
            books.Add(new Book() { Title = "C# 6.0 core 1.0" });
            return books;
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