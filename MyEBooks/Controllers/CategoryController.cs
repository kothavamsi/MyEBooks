using System.Web.Mvc;
using MyEBooks.Core;
using MyEBooks.LogHandler;
using MyEBooks.Models;
using System.Linq;
using MyEBooks.PagerHandler.PagerSettingsHandler;
using System;

namespace MyEBooks.Controllers
{
    public class CategoryController : Controller
    {
        [HttpPost]
        public ActionResult Index(string categoryName)
        {
            return Redirect(string.Format("/{0}/{1}", "category", categoryName));
        }

        [HttpGet]
        public ActionResult Index(string categoryName, int pageNo)
        {
            var searchResult = GetBookCategoryResult(categoryName, pageNo);
            return View("Result", searchResult);
        }

        private SearchResult GetBookCategoryResult(string categoryName, int pageNo)
        {
            SearchResult searchResult;
            var books = new BookManager().GetBooksByCategory(categoryName);
            var displayedBooks = books.Skip((pageNo - 1) * PagerSettings.PageSize).Take(PagerSettings.PageSize).ToList();
            int totalItems = books.Count;

            searchResult = new SearchResult() { Books = books, SearchKeyword = categoryName, PageNo = pageNo, DisplayedBooks = displayedBooks };
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
