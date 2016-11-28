﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyEBooks.BookRepository.FileSystem.BooksLocationSettingsHandler;
using MyEBooks.Core;

namespace MyEBooks.Models
{
    public class ViewModelBase
    {
        public PopularTagData PopularTagData;
        public NavigationBar NavigationBar;

        public ViewModelBase()
        {
        }

        IRepository _repository;
        public ViewModelBase(IRepository repository):base()
        {
            _repository = repository;
            NavigationBar = new NavigationBar(_repository);
            PopularTagData = new PopularTagData();
        }
    }

    public class NavigationBar
    {
        public bool RenderSortByListMenu { get; set; }
        public IList<CategoryListItem> Categories { get; set; }
        public IList<SortByListItem> SortByListItems { get; set; }
        
        IRepository _repository;
        public NavigationBar(IRepository repository)
        {
            _repository = repository;
            RenderSortByListMenu = true;
            Categories = _repository.GetCategoryListItems();
            SortByListItems = _repository.GetSortByListItems();
        }
    }
}