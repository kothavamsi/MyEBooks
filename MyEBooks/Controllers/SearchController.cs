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
    public class SearchController : Controller
    {
        [HttpPost]
        public ActionResult Index(string keyword)
        {
            return Redirect(string.Format("/{0}/{1}","search",keyword));
        }

        [HttpGet]
        public ActionResult Index(string keyword, int pageNo)
        {
            var searchResult = GetSearchResult(keyword, pageNo);
            return View("Result", searchResult);
        }

        private SearchResult GetSearchResult(string keyword, int pageNo)
        {
            SearchResult searchResult;
            if (string.IsNullOrEmpty(keyword))
            {
                searchResult = new SearchResult() { Books = new List<Book>(), SearchKeyword = "", PageNo = pageNo };
            }
            else
            {
                var books = FindBooks(keyword);
                searchResult = new SearchResult() { Books = books, SearchKeyword = keyword, PageNo = pageNo };
            }
            LogManager.Write(new RequestInformation()
            {
                RequestUrl = Request.RequestType + " " + Request.Url,
                UserAgent = Request.UserAgent,
                IpAddress = Request.UserHostAddress
            }.ToString(), Category.Information);
            return searchResult;
        }

        private IList<Book> FindBooks(string keyword)
        {
            IList<Book> books = new BookManager().GetBooksByKeyword(keyword);
            return books;
        }

    }
}
