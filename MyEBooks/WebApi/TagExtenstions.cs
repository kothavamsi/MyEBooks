using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyEBooks.WebApi
{
    public static class TagExtenstions
    {
        public static PopularSearchTag Create(this PopularSearchTag tag, string keyWord)
        {
            PopularSearchTag pst = new PopularSearchTag()
            {
                Count = 1,
                CreatedOn = DateTime.Now,
                LastSearchedOn = DateTime.Now,
                Keyword = keyWord
            };
            return pst;
        }
    }
}