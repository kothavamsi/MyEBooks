using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyEBooks.WebApi.Repository
{
    interface IRepository
    {
        IEnumerable<Book> GetAllBooks();
        Book GetBook(int id);
        void DeleteBook(int id);
        void AddBook(Book book);
        void UpdateBook(Book book);
    }
}
