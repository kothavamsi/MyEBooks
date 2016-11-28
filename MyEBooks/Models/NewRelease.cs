using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyEBooks.Models
{
    public class NewRelease:ViewModelBase
    {
        public string Title { get; set; }
        public NewRelease()
        {
            Title = "vamsi NewRelease";
        }
    }
}