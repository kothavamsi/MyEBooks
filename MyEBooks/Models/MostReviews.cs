using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyEBooks.Models
{
    public class MostReviews:ViewModelBase
    {
        public string Title { get; set; }
        public MostReviews()
        {
            Title = "vamsi MostReviews";
        }

    }
}