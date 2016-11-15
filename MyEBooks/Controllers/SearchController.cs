using System.Web.Mvc;
using MyEBooks.Core;
using MyEBooks.LogHandler;
using MyEBooks.Models;
using System.Collections.Generic;
using System.Linq;
using MyEBooks.PagerHandler.PagerSettingsHandler;
using System;

namespace MyEBooks.Controllers
{
    public class SearchController : Controller
    {
        [HttpPost]
        public ActionResult Index(string keyword)
        {
            return Redirect(string.Format("/{0}/{1}", "search", keyword));
        }

        [HttpGet]
        public ActionResult Index(string keyword, int pageNo)
        {
            SearchResult searchResult = new SearchResult();
            if (string.IsNullOrEmpty(keyword))
            {
                searchResult.IsAvailable = false;
            }
            else
            {
                searchResult = GetBookSearchResult(keyword, pageNo);
            }
            return View("Result", searchResult);
        }

        private SearchResult GetBookSearchResult(string keyword, int pageNo)
        {
            SearchResult searchResult;
            var books = new BookManager().GetBooksByKeyword(keyword);
            var displayedBooks = books.Skip((pageNo - 1) * PagerSettings.PageSize).Take(PagerSettings.PageSize).ToList();
            int totalItems = books.Count;

            searchResult = new SearchResult() { Books = books, SearchKeyword = keyword, PageNo = pageNo, DisplayedBooks = displayedBooks };
            searchResult.IsAvailable = books.Count > 0 ? true : false;
            searchResult.Pager = new Pager().GetPager(totalItems, pageNo);
            if (pageNo < 1 || pageNo > searchResult.Pager.TotalPages)
            {
                throw new Exception("Vamsi,Handle this Custom Error 404 - The page you are looking for no longer exists. Perhaps you can return back to the site's homepage and see if you can find what you are looking for. Or, you can try finding it by using the search form.");
            }

            LogManager.Write(new RequestInformation()
            {
                RequestUrl = Request.RequestType + " " + Request.Url,
                UserAgent = Request.UserAgent,
                IpAddress = Request.UserHostAddress
            }.ToString(), Category.Information);
            return searchResult;
        }
    }
}
