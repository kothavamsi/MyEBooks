using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyEBooks.Core;

namespace MyEBooks.Core
{
    public class SortByListItem
    {
        public string Text { get; set; }
        public string SeoFriendlyText { get; set; }
        public string BackEndPurposeText { get; set; }
        public int Id { get; set; }
        public int Rank { get; set; }
        public bool Enabled { get; set; }
        public int Weight { get; set; }

        public SortByListItem()
        {
        }
    }
}