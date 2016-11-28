using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyEBooks.BookRepository.FileSystem.BooksLocationSettingsHandler;

namespace MyEBooks.Models
{
    public class NavBar
    {
        public bool RenderSortBy { get; set; }
        public Dictionary<string, string> Categories { get; set; }
        
        public NavBar()
        {
            RenderSortBy = true;
            LoadData();
        }
        
        public void LoadData()
        {
            Categories = BooksLocationSettings.categories;
        }
    }

    public class ViewModelBase
    {
        public PopularTagData PopularTagData;
        public NavBar NavBar;

        public ViewModelBase()
        {
            NavBar = new NavBar();
            LoadData();
        }

        public void LoadData()
        {
            PopularTagData = new PopularTagData();
        }
    }
}