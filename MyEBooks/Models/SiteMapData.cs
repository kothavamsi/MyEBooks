using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyEBooks.WebApi;
using MyEBooks.Models;

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

    public class PopularSearchData
    {
        public string Title { get; set; }
        public IEnumerable<TagData> PopularSearchTags { get; set; }
        public PopularSearchData()
        {
            PopularSearchTags = new List<TagData>();
        }

        
    }

    public class PopularAuthorData
    {
        public string Title { get; set; }
        public IEnumerable<TagData> PopularAuthorTags { get; set; }
        public PopularAuthorData()
        {
            PopularAuthorTags = new List<TagData>();
        }
    }

    public class PopularPublisherData
    {
        public string Title { get; set; }
        public IEnumerable<TagData> PopularPublisherTags { get; set; }
        public PopularPublisherData()
        {
            PopularPublisherTags = new List<TagData>();
        }
    }

    public class SiteMapData
    {
        public PopularSearchData PopularSearchData;
        public PopularAuthorData PopularAuthorData;
        public PopularPublisherData PopularPublisherData;
        public SiteMapData()
        {
            PopularSearchData = new PopularSearchData();
            PopularAuthorData = new PopularAuthorData();
            PopularPublisherData = new PopularPublisherData();
        }

        public void LoadSiteMapData()
        {
            PopularSearchData.PopularSearchTags = MapDBPopularSearchTagToViewTagData(new TagManager().GetPopularSearchTagsBySearchHits(50));
        }

        public IEnumerable<TagData> MapDBPopularSearchTagToViewTagData(IEnumerable<PopularSearchTag> dbTags)
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