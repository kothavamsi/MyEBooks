using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyEBooks.WebApi
{
    public class PopularSearchTagsController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<PopularSearchTag> Get(string filterBy)
        {
            return new TagManager().GetAllPopularSearchTags(filterBy);
        }

        //// GET api/<controller>/5
        //public PopularSearchTag Get(string filterBy, int id)
        //{
        //    return new TagManager().GetPopularSearchTag(filterBy, id);
        //}

        // POST api/<controller>
        public void Post([FromBody]PopularSearchTag tag)
        {
            new TagManager().PostPopularSearchTag(tag);
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]PopularSearchTag tag)
        {
            new TagManager().PutPopularSearchTag(id,tag);
        }

        // DELETE api/<controller>/5
        public void Delete(PopularSearchTag tag)
        {
            new TagManager().DeletePopularSearchTag(tag);
        }
    }
}