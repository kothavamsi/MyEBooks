using System.Web.Mvc;
using MyEBooks.Core;
using MyEBooks.LogHandler;
using MyEBooks.Models;
using System.Collections.Generic;
using System.Linq;
using MyEBooks.PagerHandler.PagerSettingsHandler;
using System;
using MyEBooks.WebApi;

namespace MyEBooks.Controllers
{
    public class SearchController : Controller
    {
        [HttpPost]
        public ActionResult Index(string keyword)
        {
            // TODO RedirectToAction(...);
            return Redirect(string.Format("/{0}/{1}", "search", keyword));
        }

        [HttpGet]
        public ActionResult Index(string keyword, int pageNo = 1)
        {
            var searchResult = GetBookSearchResult(keyword, pageNo);
            if (searchResult.FoundResult)
            {
                new TagManager().PostPopularTag(new PopularTag().CreateTagInstance(keyword));
            }
            return View("Result", searchResult);
        }

        private SearchResult GetBookSearchResult(string keyword, int pageNo)
        {
            SearchResult searchResult;
            if (!IsSearchKeywordValid(keyword))
            {
                return new SearchResult() { SearchKeyword = keyword, PageNo = pageNo, FoundResult = false };
            }
            if (!IsPageNumberInValidRange(pageNo, keyword))
            {
                throw new Exception(string.Format("The Page No:{0} Is NotValid", pageNo));
            }

            var books = new BookManager().GetBooksByKeyword(keyword);
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
                SearchKeyword = keyword,
                FoundResult = foundResult,
                NavBar = new NavBar() { RenderSortBy = false }
            };
            return searchResult;
        }

        private bool IsSearchKeywordValid(string keyword)
        {
            return !string.IsNullOrEmpty(keyword);
        }

        private bool IsPageNumberInValidRange(int pageNo, string keyword)
        {
            var totalPages = GetTotalPages(keyword);
            var retVal = (pageNo == 1 || pageNo > 1 && pageNo <= totalPages);
            return retVal;
        }

        private int GetTotalPages(string keyword)
        {
            var books = new BookManager().GetBooksByKeyword(keyword);
            var totalPages = new Pager().GetPageCount(books.Count);
            return totalPages;
        }
    }
}
