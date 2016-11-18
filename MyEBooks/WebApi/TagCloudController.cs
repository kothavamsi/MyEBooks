using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyEBooks.WebApi
{
    public class Tag
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public double Weight { get; set; }
        public string Link { get; set; }
    }

    public class TagRepository
    {
        public List<Tag> tags;
        public TagRepository()
        {
            tags = new List<Tag>()
            {
                    new Tag() { Text= "Lorem", Weight= 13, Link= "https=//github.com/lucaong/jQCloud" },
                    new Tag() { Text= "Ipsum", Weight= 10.5, Link= "http=//jquery.com/" },
                    new Tag() { Text= "Dolor", Weight= 9.4 },
                    new Tag() { Text= "Sit", Weight= 8 },
                    new Tag() { Text= "Amet", Weight= 6.2 },
                    new Tag() { Text= "Consectetur", Weight= 5 },
                    new Tag() { Text= "Adipiscing", Weight= 5 },
                    new Tag() { Text= "Elit", Weight= 5 },
                    new Tag() { Text= "Nam et", Weight= 5 },
                    new Tag() { Text= "Leo", Weight= 4 },
                    new Tag() { Text= "Sapien", Weight= 4, Link= "http=//www.lucaongaro.eu/" },
                    new Tag() { Text= "Pellentesque", Weight= 3 },
                    new Tag() { Text= "habitant", Weight= 3 },
                    new Tag() { Text= "morbi", Weight= 3 },
                    new Tag() { Text= "tristisque", Weight= 3 },
                    new Tag() { Text= "senectus", Weight= 3 },
                    new Tag() { Text= "et netus", Weight= 3 },
                    new Tag() { Text= "et malesuada", Weight= 3 },
                    new Tag() { Text= "fames", Weight= 2 },
                    new Tag() { Text= "ac turpis", Weight= 2 },
                    new Tag() { Text= "egestas", Weight= 2 },
                    new Tag() { Text= "Aenean", Weight= 2 },
                    new Tag() { Text= "vestibulum", Weight= 2 },
                    new Tag() { Text= "elit", Weight= 2 },
                    new Tag() { Text= "sit amet", Weight= 2 },
                    new Tag() { Text= "metus", Weight= 2 },
                    new Tag() { Text= "adipiscing", Weight= 2 },
                    new Tag() { Text= "ut ultrices", Weight= 2 },
                    new Tag() { Text= "justo", Weight= 1 },
                    new Tag() { Text= "dictum", Weight= 1 },
                    new Tag() { Text= "Ut et leo", Weight= 1 },
                    new Tag() { Text= "metus", Weight= 1 },
                    new Tag() { Text= "at molestie", Weight= 1 },
                    new Tag() { Text= "purus", Weight= 1 },
                    new Tag() { Text= "Curabitur", Weight= 1 },
                    new Tag() { Text= "diam", Weight= 1 },
                    new Tag() { Text= "dui", Weight= 1 },
                    new Tag() { Text= "ullamcorper", Weight= 1 },
                    new Tag() { Text= "id vuluptate ut", Weight= 1 },
                    new Tag() { Text= "mattis", Weight= 1 },
                    new Tag() { Text= "et nulla", Weight= 1 },
                    new Tag() { Text= "Sed", Weight= 1 }
            };
        }

        public IEnumerable<Tag> GetTags()
        {
            return tags;
        }

    }

    public class TagCloudController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<Tag> Get()
        {
            return new TagRepository().GetTags();
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]Tag tag)
        {

        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]Tag tag)
        {

        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}