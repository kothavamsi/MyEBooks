using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyEBooks.Models
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN_10 { get; set; }
        public string ISBN_13 { get; set; }
        public int Pages { get; set; }
        public DateTime PublishedDate { get; set; }
        public double SizeMB { get; set; }
        public string BookCategory { get; set; }
    }
}
