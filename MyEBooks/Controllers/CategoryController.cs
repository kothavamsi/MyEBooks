using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyEBooks.Models;
using MyEBooks.Core;
using MyEBooks.LogHandler;

namespace MyEBooks.Controllers
{
    public class CategoryController : Controller
    {
        public ActionResult Index(string categoryName)
        {
            SearchResult searchResult;
            if (string.IsNullOrEmpty(categoryName))
            {
                searchResult = new SearchResult() { Books = new List<Book>(), SearchKeyword = "" };
            }
            else
            {
                var books = FindBooks(categoryName);
                searchResult = new SearchResult() { Books = books, SearchKeyword = categoryName };
            }
            LogManager.Write(new RequestInformation()
            {
                RequestUrl = Request.RequestType + " " + Request.Url,
                UserAgent = Request.UserAgent,
                IpAddress = Request.UserHostAddress
            }.ToString(), Category.Information);
            return View("Result", searchResult);
        }

        private IList<Book> FindBooks(string categoryName)
        {
            IList<Book> books = new BookManager().GetBooksByCategory(categoryName);
            return books;
        }

    }
}
