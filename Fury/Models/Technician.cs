using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fury.Models
{
    public class Technician
    {
        [Required]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public int Auth { get; set; }
    }
}