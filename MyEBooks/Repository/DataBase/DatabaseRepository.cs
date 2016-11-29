using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProductsEStore.Models;
using ProductsEStore.Repository.DataBase;

namespace ProductsEStore.Core
{
    public class DatabaseRepository : IRepository
    {
        ProductStoreEntities dbContext;
        public DatabaseRepository()
        {
            dbContext = new ProductStoreEntities();
        }

        public IList<CategoryListItem> GetCategoryListItems()
        {
            //var r = from cat in dbContext.Categories
            return null;
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
                Name="upload(default)",
                SeoFriendlyName="upload",
            });

            sortByLstItems.Add(new SortByListItem()
            {
                Id = 2,
                Enabled = true,
                Rank = 3,
                Weight = 1,
                Name = "Publication Date",
                SeoFriendlyName = "publication-date",
            });
            sortByLstItems.Add(new SortByListItem()
            {
                Id = 3,
                Enabled = true,
                Rank = 1,
                Weight = 1,
                Name = "Avg. User Review",
                SeoFriendlyName = "avg-user-review",
            });

            return sortByLstItems;
        }

        public IList<IProduct> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public IList<IProduct> GetProductsByYearMonth(int year, int month)
        {
            throw new NotImplementedException();
        }

        public Response GetProducts(RequestCriteria requestCriteria)
        {
            throw new NotImplementedException();
        }

        public void SaveContact(ProductsEStore.Models.Contact contact)
        {
            throw new NotImplementedException();
        }
    }
}