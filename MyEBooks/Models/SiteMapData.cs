﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyEBooks.WebApi;
using MyEBooks.Models;
using MyEBooks.SiteMap;
using MyEBooks.Core;

namespace MyEBooks.Models
{
    public class TagData
    {
        public string TagName { get; set; }
        public string Url { get; set; }
        public int Weight { get; set; }

        public TagData()
        {
        }
    }

    public class PopularTagData
    {
        public string Title { get; set; }
        public IEnumerable<TagData> PopularTags { get; set; }
        public int TotalTagsToGet { get; set; }

        public PopularTagData()
        {
            PopularTags = new List<TagData>();
            TotalTagsToGet = SiteMapSettings.PopularTags.TotalItems;
        }
    }

    public class PopularAuthorData
    {
        public string Title { get; set; }
        public IEnumerable<TagData> PopularAuthorTags { get; set; }
        public int TotalTagsToGet { get; set; }
        public PopularAuthorData()
        {
            PopularAuthorTags = new List<TagData>();
            TotalTagsToGet = SiteMapSettings.PopularAuthorTags.TotalItems;
        }
    }

    public class PopularPublisherData
    {
        public string Title { get; set; }
        public IEnumerable<TagData> PopularPublisherTags { get; set; }
        public int TotalTagsToGet { get; set; }
        public PopularPublisherData()
        {
            PopularPublisherTags = new List<TagData>();
            TotalTagsToGet = SiteMapSettings.PopularPublisherTags.TotalItems;
        }
    }

    public class MonthlyTreeItem
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public string DisplayValue { get; set; }
        public MonthlyTreeItem()
        {
        }
    }

    public class MonthlyData
    {
        public string Title { get; set; }
        public IList<MonthlyTreeItem> MonthlyTreeItems { get; set; }
        public MonthlyData()
        {
            MonthlyTreeItems = new List<MonthlyTreeItem>();
            LoadMonthlyData();
        }

        public void LoadMonthlyData()
        {
            int startMonth, startYear, endMonth, endYear;

            if (SiteMapSettings.BooksByMonth.Relative.Enabled == true)
            {
                startMonth = SiteMapSettings.BooksByMonth.Relative.FromMonth;
                startYear = SiteMapSettings.BooksByMonth.Relative.FromYear;
            }
            else
            {
                startMonth = SiteMapSettings.BooksByMonth.Fixed.FromMonth;
                startYear = SiteMapSettings.BooksByMonth.Fixed.FromYear;
            }

            endMonth = DateTime.Now.Month;
            endYear = DateTime.Now.Year;

            DateTime dt = new DateTime(endYear, endMonth, 1);
            while (!(dt.Month == startMonth && dt.Year == startYear))
            {
                MonthlyTreeItems.Add(
                new MonthlyTreeItem()
                {
                    DisplayValue = string.Format("{0} {1} ({2})", SiteMapData.MonthNames[dt.Month], dt.Year, new BookManager().GetBooksByYearMonth(dt.Year, dt.Month).Count),
                    Month = dt.Month,
                    Year = dt.Year
                });
                dt = dt.AddMonths(-1);
            }
        }
    }

    public class SiteMapData :ViewModelBase
    {
        public static string[] MonthNames = new string[] { "", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

        new public PopularTagData PopularTagData;
        public PopularAuthorData PopularAuthorData;
        public PopularPublisherData PopularPublisherData;
        public MonthlyData MonthlyData;

        public SiteMapData()
        {
            PopularTagData = new PopularTagData();
            PopularAuthorData = new PopularAuthorData();
            PopularPublisherData = new PopularPublisherData();
            MonthlyData = new MonthlyData();
            LoadSiteMapData();
        }

        public void LoadSiteMapData()
        {
            PopularTagData.PopularTags = MapDBPopularSearchTagToViewTagData(new TagManager().GetPopularTagsByRecent(SiteMapSettings.PopularTags.TotalItems));
        }

        public IEnumerable<TagData> MapDBPopularSearchTagToViewTagData(IEnumerable<PopularTag> dbTags)
        {
            var tags = from dbTag in dbTags
                       select new TagData()
                       {
                           TagName = dbTag.Keyword,
                           Url = "",
                           Weight = dbTag.Count
                       };
            return tags;
        }

    }
}