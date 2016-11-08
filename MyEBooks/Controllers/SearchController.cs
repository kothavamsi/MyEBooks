using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyEBooks.Models;
using MyEBooks.Core;

namespace MyEBooks.Controllers
{
    public class SearchController : Controller
    {
        public ActionResult Index(string keyword)
        {
            SearchResult searchResult;
            if (string.IsNullOrEmpty(keyword))
            {
                searchResult = new SearchResult() { Books = new List<Book>(), SearchKeyword = "" };
            }
            else
            {
                var books = FindBooks(keyword);
                searchResult = new SearchResult() { Books = books, SearchKeyword = keyword };
            }
            return View("Result", searchResult);
        }

        private IList<Book> FindBooks(string keyword)
        {
            IList<Book> books = new BookManager().GetBooksByKeyword(keyword);
            return books;
        }

    }
}
