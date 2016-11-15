using System.Web.Mvc;
using MyEBooks.Core;
using MyEBooks.LogHandler;
using MyEBooks.Models;
using System.Linq;
using MyEBooks.PagerHandler.PagerSettingsHandler;

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
            var displayedBooks = books.Skip((pageNo - 1) * PagerSettings.PageSize).Take(PagerSettings.PageSize).ToList(); ;
            searchResult = new SearchResult() { Books = books, SearchKeyword = categoryName, PageNo = pageNo, DisplayedBooks = displayedBooks };
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
