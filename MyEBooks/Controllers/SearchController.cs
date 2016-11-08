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
            if (string.IsNullOrEmpty(keyword))
            {
                return View("Error");
            }
            else
            {
                var result = FindBooks(keyword);
                return View("Result", result);
            }
        }

        private IList<Book> FindBooks(string keyword)
        {
            IList<Book> books = new BookManager().GetBooksByKeyword(keyword);
            return books;
        }

    }
}
