using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fury.Models
{
    public class User
    {
        [Required]
        public int ID { get; set; }
        [Required]
        [Display (Name ="stock Name")]
        public string Name { get; set; }
        public string Password { get; set; }
        
    }
}