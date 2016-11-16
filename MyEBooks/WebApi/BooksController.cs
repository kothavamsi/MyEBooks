using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MyEBooks.WebApi.Repository;
using MyEBooks.WebApi;

namespace MyEBooks
{
    public class BooksController : ApiController
    {
        IRepository repository = new Repository();

        // GET api/<controller>
        public IEnumerable<Book> Get()
        {
            return repository.GetAllBooks();
        }

        // GET api/<controller>/5
        public Book Get(int id)
        {
            return repository.GetBook(id);
        }

        // POST api/<controller>
        public void Post([FromBody]Book book)
        {
            repository.AddBook(book);
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]Book book)
        {
            repository.UpdateBook(book);
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            repository.DeleteBook(id);
        }
    }
}