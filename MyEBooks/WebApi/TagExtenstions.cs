using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyEBooks.WebApi
{
    public static class TagExtenstions
    {
        public static PopularTag Create(this PopularTag tag, string keyWord)
        {
            PopularTag pt = new PopularTag()
            {
                Count = 1,
                CreatedOn = DateTime.Now,
                LastSearchedOn = DateTime.Now,
                Keyword = keyWord
            };
            return pt;
        }
    }
}