using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyEBooks.Models
{
    public class ContactUs
    {
        public int Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
