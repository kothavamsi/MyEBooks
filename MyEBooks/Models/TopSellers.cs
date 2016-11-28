using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyEBooks.Models
{
    public class TopSellers : ViewModelBase
    {
        public string Title { get; set; }
        public TopSellers()
        {
            Title = "vamsi topsellers";
        }
    }
}