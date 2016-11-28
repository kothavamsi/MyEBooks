using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyEBooks.Core
{
    public class DatabaseRepository : IRepository
    {
        public IList<Models.Book> GetBooksByKeyword(string keyword)
        {
            throw new NotImplementedException();
        }

        public IList<Models.Book> GetAllBooks()
        {
            throw new NotImplementedException();
        }

        public IList<Models.Book> GetBooksByCategory(string categoryName)
        {
            throw new NotImplementedException();
        }

        public IList<Models.Book> GetBooksByYearMonth(int year, int month)
        {
            throw new NotImplementedException();
        }


        public IList<CategoryListItem> GetCategoryListItems()
        {
            IList<CategoryListItem> categoryLstItems = new List<CategoryListItem>();
            categoryLstItems.Add(new CategoryListItem()
            {
                Id = 1,
                ParentId = 0,
                Rank = 2,
                Weight = 1,
                Enabled = true,
                Text = "Wcf Technologies",
                SeoFriendlyText = "Wcf-Technologies",
                BackEndPurposeText = "Wcf"
            });

            categoryLstItems.Add(new CategoryListItem()
            {
                Id = 2,
                ParentId = 0,
                Rank = 1,
                Weight = 2,
                Enabled = true,
                Text = "LINQ Technologies",
                SeoFriendlyText = "linq-Technologies",
                BackEndPurposeText = "Linq"
            });
            categoryLstItems.Add(new CategoryListItem()
            {
                Id = 3,
                ParentId = 0,
                Rank = 3,
                Weight = 2,
                Enabled = true,
                Text = "ASP Core 1.0",
                SeoFriendlyText = "ASP-Core-1.0",
                BackEndPurposeText = "AspCore1.0"
            });

            return categoryLstItems;
        }

        public IList<SortByListItem> GetSortByListItems()
        {
            IList<SortByListItem> sortByLstItems = new List<SortByListItem>();
            sortByLstItems.Add(new SortByListItem()
            {
                Id=1,
                Enabled = true,
                Rank=2,
                Weight=1,
                Text="upload(default)",
                SeoFriendlyText="upload",
                BackEndPurposeText = "upload"
            });

            sortByLstItems.Add(new SortByListItem()
            {
                Id = 2,
                Enabled = true,
                Rank = 3,
                Weight = 1,
                Text = "Publication Date",
                SeoFriendlyText = "publication-date",
                BackEndPurposeText = "publicationdate"
            });
            sortByLstItems.Add(new SortByListItem()
            {
                Id = 3,
                Enabled = true,
                Rank = 1,
                Weight = 1,
                Text = "Avg. User Review",
                SeoFriendlyText = "avg-user-review",
                BackEndPurposeText = "avgUserReview"
            });

            return sortByLstItems;
        }


        public Response GetBooksByRequestCriteria(RequestCriteria requestCriteria)
        {
            throw new NotImplementedException();
        }


        public Response GetProducts(RequestCriteria requestCriteria)
        {
            throw new NotImplementedException();
        }
    }
}