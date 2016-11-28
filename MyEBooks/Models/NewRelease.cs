using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyEBooks.Core;

namespace MyEBooks.Models
{
    public class NewRelease : ViewModelBase
    {
        public string Title { get; set; }

        // Dependency Injection
        public NewRelease(IRepository repository)
            : base(repository)
        {
            Title = "vamsi NewRelease";
        }
    }
}