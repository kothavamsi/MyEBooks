using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyEBooks.Models;

namespace MyEBooks.Core
{
    public interface IRepository
    {
        IList<Book> GetBooksByKeyword(string keyword);
        IList<Book> GetAllBooks();
        IList<Book> GetBooksByCategory(string categoryName);
        IList<Book> GetBooksByYearMonth(int year, int month);

        /// <summary>
        /// Gets Category ListMenu Items
        /// </summary>
        /// <returns>List of CategoryListItem</returns>
        IList<CategoryListItem> GetCategoryListItems();

        /// <summary>
        /// Gets SortBy ListMenu Items
        /// </summary>
        /// <returns>List of CategoryListItem</returns>
        IList<SortByListItem> GetSortByListItems();

        /// <summary>
        /// Gets Products that matches RequestCriteria
        /// </summary>
        /// <param name="requestCriteria">Selection Criteria for the type of products we want to include in response </param>
        /// <returns>Response that contains products matched to RequestCriteria</returns>
        Response GetProducts(RequestCriteria requestCriteria);
    }
}