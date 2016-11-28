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

        public ActionResult Index(string categoryName, string sort="post-date", int pageNo = 1)
        {
            var searchResult = GetBookCategoryResult(categoryName, pageNo);
            return View("Result", searchResult);
        }

        private SearchResult GetBookCategoryResult(string categoryName, int pageNo)
        {
            SearchResult searchResult;
            if (!IsSearchCategoryValid(categoryName))
            {
                return new SearchResult() { SearchKeyword = categoryName, PageNo = pageNo, FoundResult = false };
            }
            if (!IsPageNumberInValidRange(pageNo, categoryName))
            {
                throw new Exception(string.Format("The Page No:{0} Is NotValid", pageNo));
            }

            var books = new BookManager().GetBooksByCategory(categoryName);
            int totalBooks = books.Count;
            var displayedBooks = books.Skip((pageNo - 1) * PagerSettings.PageSize).Take(PagerSettings.PageSize).ToList();
            var pager = new Pager().GetPager(totalBooks, pageNo);
            var foundResult = books.Count > 0 ? true : false;

            searchResult = new SearchResult()
            {
                Books = books,
                DisplayedBooks = displayedBooks,
                PageNo = pageNo,
                Pager = pager,
                SearchKeyword = categoryName,
                FoundResult = foundResult
            };
            return searchResult;
        }

        private bool IsSearchCategoryValid(string categoryName)
        {
            return !string.IsNullOrEmpty(categoryName);
        }

        private bool IsPageNumberInValidRange(int pageNo, string categoryName)
        {
            var totalPages = GetTotalPages(categoryName);
            var retVal = (pageNo == 1 || pageNo > 1 && pageNo <= totalPages);
            return retVal;
        }

        private int GetTotalPages(string categoryName)
        {
            var books = new BookManager().GetBooksByCategory(categoryName);
            var totalPages = new Pager().GetPageCount(books.Count);
            return totalPages;
        }
    }
}
