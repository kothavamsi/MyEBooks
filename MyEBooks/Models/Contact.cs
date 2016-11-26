﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace MyEBooks.Models
{
    public class Contact
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter First name")]
        public string Fname { get; set; }
        [Required(ErrorMessage = "Please enter Last name")]
        public string Lname { get; set; }
        [Required(ErrorMessage = "Please enter your email address")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }
        public string Description { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}