using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyEBooks.Models;
using System.Configuration;
using System.IO;
using System.Text.RegularExpressions;
using MyEBooks.BookRepository.FileSystem.BooksLocationSettingsHandler;

namespace MyEBooks.Core
{
    public class FileSystemRepository : IBookRepository
    {
        public IList<Book> GetBooksByKeyword(string keyword)
        {
            IList<Book> books = new List<Book>();
            books = FindBooks(keyword);
            return books;
        }

        public IList<Book> GetAllBooks()
        {
            throw new NotImplementedException();
        }

        public IList<Book> GetBooksByCategory(string categoryName)
        {
            List<Book> foundBooks = new List<Book>();
            string categoryLocationTemplate;
            if (BooksLocationSettings.categories.TryGetValue(categoryName, out categoryLocationTemplate))
            {
                var categoryLocations = categoryLocationTemplate.Split(';');
                foreach (var categoryLocation in categoryLocations)
                {
                    string[] files = Directory.GetFiles(categoryLocation, "*.*", SearchOption.AllDirectories);
                    foreach (string file in files)
                    {
                        var book = MapFileToBook(file);
                        foundBooks.Add(book);
                    }
                }
            }
            return foundBooks;
        }

        private static List<Book> FindBooks(string keyword)
        {
            List<Book> foundBooks = new List<Book>();
            foreach (var path in BooksLocationSettings.Locations)
            {
                var r = FindBooksAtPath(keyword, path);
                foundBooks.AddRange(r);
            }
            return foundBooks;
        }

        private static List<Book> FindBooksAtPath(string keyword, string path)
        {
            List<Book> foundBooks = new List<Book>();
            string[] files = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
            var foundFiles = files.Select(f => new { FileNameOrginalCase = f, FileNameLowerCase = f.ToLower() }).Where(f => FileNameContains(f.FileNameLowerCase, keyword)).Select(f => f.FileNameOrginalCase).ToList();
            foreach (string file in foundFiles)
            {
                var book = MapFileToBook(file);
                foundBooks.Add(book);
            }
            return foundBooks;
        }

        private static Book MapFileToBook(string file)
        {
            FileInfo fi = new FileInfo(file);
            double fileLength = fi.Length;
            double kbFileLength = fileLength / 1024;
            double mbFileLength = kbFileLength / 1024;
            return new Book() { Title = fi.Name, SizeMB = mbFileLength, PublishedDate = fi.CreationTime };
        }

        private static bool FileNameContains(string searchString, string keyword)
        {
            var retVal = false;
            Regex regEx = new Regex(keyword);
            retVal = regEx.IsMatch(searchString);
            return retVal;
        }

    }
}