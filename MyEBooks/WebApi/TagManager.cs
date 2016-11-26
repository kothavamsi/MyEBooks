using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyEBooks.WebApi
{
    public enum FILTER
    {
        recent = 1,
        hit = 2
    }

    public class TagManager
    {
        MyEbooksEntities dbContext;
        public TagManager()
        {
            dbContext = new MyEbooksEntities();
        }

        public IEnumerable<PopularSearchTag> GetAllPopularSearchTags(string filterBy)
        {
            IEnumerable<PopularSearchTag> tags = new List<PopularSearchTag>();
            if (filterBy == "recent")
            {
                tags = from pst in dbContext.PopularSearchTags orderby pst.LastSearchedOn descending select pst;
            }
            else
            {
                tags = from pst in dbContext.PopularSearchTags orderby pst.Count ascending select pst;
            }
            return tags;
        }

        public IEnumerable<PopularSearchTag> GetPopularSearchTagsByHits(int totalItems)
        {
            IEnumerable<PopularSearchTag> tags = GetAllPopularSearchTags("hit");
            return tags.Take(totalItems);
        }

        public IEnumerable<PopularSearchTag> GetPopularSearchTagsByRecent(int totalItems)
        {
            IEnumerable<PopularSearchTag> tags = GetAllPopularSearchTags("recent");
            return tags.Take(totalItems);
        }
        
        //public PopularSearchTag GetPopularSearchTag(string filterBy, int id)
        //{
        //    var popularSearchTag = from pst in dbContext.PopularSearchTags where pst.Id == id select pst;
        //    return popularSearchTag.FirstOrDefault();
        //}

        public void PostPopularSearchTag(PopularSearchTag tag)
        {
            var popularSearchTag = GetPopularSearchTag(tag.Keyword);
            if (popularSearchTag == null)
            {
                AddPopularSearchTag(tag);
            }
            else
            {
                popularSearchTag.Count += 1;
                popularSearchTag.LastSearchedOn = DateTime.Now;
                UpdatePopularSearchTag(popularSearchTag.Id, popularSearchTag);
            }
        }

        public void PutPopularSearchTag(int id, PopularSearchTag tag)
        {
            UpdatePopularSearchTag(id, tag);
        }

        public void DeletePopularSearchTag(PopularSearchTag tag)
        {
            var popularSearchTag = dbContext.PopularSearchTags.Where(pst => pst.Id == tag.Id).Select(pst => pst).FirstOrDefault();
            dbContext.DeleteObject(popularSearchTag);
            dbContext.SaveChanges();
        }

        private PopularSearchTag GetPopularSearchTag(string keyword)
        {
            var popularSearchTag = from pst in dbContext.PopularSearchTags where pst.Keyword == keyword select pst;
            return popularSearchTag.FirstOrDefault();
        }

        private void AddPopularSearchTag(PopularSearchTag tag)
        {
            dbContext.AddToPopularSearchTags(tag);
            dbContext.SaveChanges();
        }

        private void UpdatePopularSearchTag(int id, PopularSearchTag tag)
        {
            var popularSearchTag = dbContext.PopularSearchTags.Where(pst => pst.Id == id).Select(pst => pst).FirstOrDefault();
            popularSearchTag.Id = tag.Id;
            popularSearchTag.Keyword = tag.Keyword;
            popularSearchTag.LastSearchedOn = DateTime.Now;
            popularSearchTag.Count = tag.Count;
            popularSearchTag.CreatedOn = DateTime.Now;
            dbContext.SaveChanges();
        }

        //internal IEnumerable<PopularPublisherTag> GetAllPopularPublisherTags()
        //{
        //    throw new NotImplementedException();
        //}

        //internal PopularPublisherTag GetPopularPublisherTag(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //internal void AddPopularPublisherTag(PopularPublisherTag tag)
        //{
        //    throw new NotImplementedException();
        //}

        //internal void UpdatePopularPublisherTag(int id, PopularPublisherTag tag)
        //{
        //    throw new NotImplementedException();
        //}

        //internal void DeletePopularPublisherTag(PopularPublisherTag tag)
        //{
        //    throw new NotImplementedException();
        //}

        //internal IEnumerable<PopularAuthorTag> GetAllPopularAuthorTags()
        //{
        //    throw new NotImplementedException();
        //}

        //internal PopularAuthorTag GetPopularAuthorTag(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //internal void AddPopularAuthorTag(PopularAuthorTag tag)
        //{
        //    throw new NotImplementedException();
        //}

        //internal void UpdatePopularAuthorTag(int id, PopularAuthorTag tag)
        //{
        //    throw new NotImplementedException();
        //}

        //internal void DeletePopularAuthorTag(PopularAuthorTag tag)
        //{
        //    throw new NotImplementedException();
        //}


    }
}