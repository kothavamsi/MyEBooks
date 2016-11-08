using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyEBooks.Models
{
    public enum BookCategory
    {

    }

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN_10 { get; set; }
        public string ISBN_13 { get; set; }
        public int Pages { get; set; }
        public DateTime PublishedDate { get; set; }
        public int SizeMB { get; set; }
        public BookCategory BookCategory { get; set; }
    }
}
