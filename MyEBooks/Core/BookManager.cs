using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyEBooks.Models;

namespace MyEBooks.Core
{

    public class BookManager
    {
        public IBookRepository repository;
        
        public BookManager()
        {
            // default is FileSystemRepository
            this.repository = new FileSystemRepository();
        }

        public BookManager(IBookRepository repository)
        {
            this.repository = repository;
        }

        public IList<Book> GetBooksByKeyword(string keyword)
        {
            IList<Book> books = new List<Book>();
            books = repository.GetBooksByKeyword(keyword);
            return books;
        }
    }
}