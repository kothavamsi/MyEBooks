using System.Web.Mvc;
using MyEBooks.Core;
using MyEBooks.LogHandler;
using MyEBooks.Models;
using System.Collections.Generic;
using System.Linq;
using MyEBooks.PagerHandler.PagerSettingsHandler;

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
            var searchResult = GetBookSearchResult(keyword, pageNo);
            return View("Result", searchResult);
        }

        private SearchResult GetBookSearchResult(string keyword, int pageNo)
        {
            SearchResult searchResult;
            var books = new BookManager().GetBooksByKeyword(keyword);
            var displayedBooks = books.Skip((pageNo - 1) * PagerSettings.PageSize).Take(PagerSettings.PageSize).ToList();
            searchResult = new SearchResult() { Books = books, SearchKeyword = keyword, PageNo = pageNo, DisplayedBooks = displayedBooks };
            int totalItems = books.Count;
            searchResult.Pager = new Pager().GetPager(totalItems, pageNo);
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
