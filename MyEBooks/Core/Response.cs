using System.Collections.Generic;
using MyEBooks.Models;

namespace MyEBooks.Core
{
    public class Response
    {
        public IList<IProduct> ViewProducts { get; set; }
        public int ProductCount { get; set; }

        public Response()
        {

        }
    }
}