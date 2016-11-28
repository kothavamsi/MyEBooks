using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyEBooks.Models;
using MyEBooks.Core;
using MyEBooks.PagerHandler.PagerSettingsHandler;

namespace MyEBooks.Controllers
{
    public class YearAndMonthController : Controller
    {
        //
        // GET: /YearAndMonth/
        public ActionResult Index(int Year, int Month, int pageNo = 1)
        {
            var searchResult = GetBookSearchResult(Year, Month, pageNo);
            return View("Result", searchResult);
        }

        private SearchResult GetBookSearchResult(int year, int month, int pageNo)
        {
            SearchResult searchResult;
            if (!IsYearAndMonthValid(year, month))
            {
                throw new Exception("Year & Month Is NotValid");
            }
            if (!IsPageNumberInValidRange(pageNo, year, month))
            {
                throw new Exception(string.Format("The Page No:{0} Is NotValid", pageNo));
            }

            var books = new BookManager().GetBooksByYearMonth(year, month);
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
                SearchKeyword = string.Format("{0} {1}", SiteMapData.MonthNames[month], year),
                FoundResult = foundResult
            };
            return searchResult;
        }

        private bool IsYearAndMonthValid(int year, int month)
        {
            return true;
        }

        private bool IsPageNumberInValidRange(int pageNo, int year, int month)
        {
            var totalPages = GetTotalPages(year, month);
            var retVal = (pageNo == 1 || pageNo > 1 && pageNo <= totalPages);
            return retVal;
        }

        private int GetTotalPages(int year, int month)
        {
            var books = new BookManager().GetBooksByYearMonth(year, month);
            var totalPages = new Pager().GetPageCount(books.Count);
            return totalPages;
        }
    }
}
