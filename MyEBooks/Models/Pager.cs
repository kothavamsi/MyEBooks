using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyEBooks.PagerHandler.PagerSettingsHandler;

namespace MyEBooks.Models
{
    public class Pager
    {
        public bool IsRenderable { get; set; }
        public int PageSize { get; set; }
        public int TotalItems { get; set; }
        public int TotalPages { get; set; }
        public int PagerDisplayLength { get; set; }
        public int StartIndex { get; set; }
        public int EndIndex { get; set; }
        public int CurrentIndex { get; set; }
        public bool IsPreviousEnabled { get; set; }
        public bool IsNextEnabled { get; set; }
        public bool IsFirstVisible { get; set; }
        public bool IsLastVisible { get; set; }

        public Pager()
        {
            PagerDisplayLength = PagerSettings.PagerDisplayLength == 0 ? 5 : PagerSettings.PagerDisplayLength;
            PageSize = PagerSettings.PageSize == 0 ? 10 : PagerSettings.PageSize;
            IsNextEnabled = false;
            IsPreviousEnabled = false;
            IsRenderable = false;
        }

        public Pager GetPager(int totalItems, int pageNo)
        {
            CurrentIndex = pageNo;
            TotalItems = totalItems;
            TotalPages = (totalItems / PageSize) + ((totalItems % PageSize) > 0 ? 1 : 0);
            if (TotalPages > 1)
                IsRenderable = true;
            else
                IsRenderable = false;

            // If pager can move right wards
            if (TotalPages > PagerDisplayLength)
            {
                 // if pageNo can be placed at center of our pager
                if (IsPageNumberCenter(pageNo))
                {
                    var center = pageNo;
                    StartIndex = center - PagerDisplayLength / 2;
                    EndIndex = center + PagerDisplayLength / 2;
                }
                else
                {
                    //if pageNo is towrads left side of pager
                    if (pageNo <= PagerDisplayLength / 2)
                    {
                        StartIndex = 1;
                        EndIndex = StartIndex + PagerDisplayLength - 1;
                    }
                    //if pageNo is towrads right side of pager
                    else
                    {
                        EndIndex = TotalPages;
                        StartIndex = EndIndex - PagerDisplayLength + 1;
                    }
                }
            }
            // If pager can't move right wards and is a static pager
            else
            {
                StartIndex = 1;
                EndIndex = TotalPages;
            }

            // nextButton enable or disable ?
            if (IsPageAtEnd(pageNo))
            {
                IsNextEnabled = false;
                IsLastVisible = false;
            }
            else
            {
                IsNextEnabled = true;
                IsLastVisible = true;
            }

            // prevButton enable or disable ?
            if (IsPageAtStart(pageNo))
            {
                IsPreviousEnabled = false;
                IsFirstVisible = false;
            }
            else
            {
                IsPreviousEnabled = true;
                IsFirstVisible = true;
            }


            return this;
        }

        private bool IsPageNumberCenter(int pageNo)
        {
            return ((pageNo > PagerDisplayLength / 2) && ((pageNo + (PagerDisplayLength / 2)) <= TotalPages));
        }

        private bool IsPageAtStart(int pageNo)
        {
            if (pageNo == 1)
                return true;
            else
                return false;
        }

        private bool IsPageAffinityTowardsStart(int pageNo)
        {
            if (pageNo == 1)
                return true;
            else
                return false;
        }

        private bool IsPageAtEnd(int pageNo)
        {
            if (pageNo == TotalPages)
                return true;
            else
                return false;
        }

        private bool IsPageAffinityTowardsEnd(int pageNo)
        {
            if (pageNo == TotalPages)
                return true;
            else
                return false;
        }

        
    }
}