using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyEBooks.Models;
using System.Configuration;
using System.IO;
using System.Text.RegularExpressions;

namespace MyEBooks.Core
{
    public class FileSystemRepository : IBookRepository
    {
        public IList<Book> GetBooksByKeyword(string keyword)
        {
            IList<Book> books = new List<Book>();
            books.Add(new Book() { Title = "C# 6.0 core 1.0" });
            return books;
        }

        public IList<Book> GetAllBooks()
        {
            throw new NotImplementedException();
        }

        public IList<Book> GetBooksByCategory(Models.BookCategory bookCategory)
        {
            throw new NotImplementedException();
        }

        private static List<string> FindFiles(string searchString)
        {
            List<string> foundFiles = new List<string>();
            var searchPaths = ConfigurationManager.AppSettings["searchPaths"];
            var paths = searchPaths.Split(';');
            foreach (var path in paths)
            {
                var r = FindFilesAtPath(searchString, path);
                foundFiles.AddRange(r);
            }
            return foundFiles;
        }

        private static List<string> FindFilesAtPath(string searchString, string path)
        {
            List<string> foundFiles = new List<string>();
            var files = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
            foundFiles = files.Select(f => new { OrginalCase = f, LowerCase = f.ToLower() }).Where(f => CheckRegularExpressionMatch(f.LowerCase, searchString)).Select(f => f.OrginalCase).ToList();
            return foundFiles;
        }

        private static bool CheckRegularExpressionMatch(string searchString, string searchPattern)
        {
            var retVal = false;
            Regex regEx = new Regex(searchPattern);
            retVal = regEx.IsMatch(searchString);
            return retVal;
        }
    }
}