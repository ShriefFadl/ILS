using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Fury.Models
{
    public class ProContext : DbContext
    {
        public ProContext()
            :base("name=DefaultConnection")
        {

        }
        public DbSet<Production>production_form { get; set; }

    }
}