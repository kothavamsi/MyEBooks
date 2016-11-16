using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyEBooks.WebApi.Repository
{
    public class Repository : IRepository
    {
        //ConfigurationManager.ConnectionStrings["BooksContainer"].Name
        BooksContainer context = new BooksContainer();

        public IEnumerable<Book> GetAllBooks()
        {
            return context.Books;
        }

        public Book GetBook(int id)
        {
            var book = context.Books.Where(b => b.Id == id).Select(b => b).FirstOrDefault();
            return book;
        }

        public void DeleteBook(int id)
        {
            var book = context.Books.Where(b => b.Id == id).Select(b => b).FirstOrDefault();
            context.Books.DeleteObject(book);
            context.SaveChanges();
        }

        public void AddBook(Book book)
        {
            context.AddToBooks(book);
            context.SaveChanges();
        }

        public void UpdateBook(Book book)
        {
            var rBook = context.Books.Where(b => b.Id == book.Id).Select(b => b).FirstOrDefault();
            rBook.Title = book.Title;
            rBook.Id = book.Id;
            context.SaveChanges();
        }
    }
}