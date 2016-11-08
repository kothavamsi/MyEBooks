using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyEBooks.LogHandler
{
    public enum Category
    {
        Information,
        Warning,
        Error,
        Critical
    }

    public class LogEntry
    {
        public int Sno { get; set; }
        public string Message { get; set; }
        public DateTime TimeStamp { get; set; }
        public Category Category { get; set; }

        static LogEntry()
        {

        }
    }
}
