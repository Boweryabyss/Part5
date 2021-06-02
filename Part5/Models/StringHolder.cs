using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Part5.Models
{
    public class StringHolder
    {
        public int ID { get; set; }
        public string Lowercase { get; set; }
        public string Uppercase { get; set; }
        public string Inverted { get; set; }
    }

    public class StringHolderDbContext : DbContext
    {
        public DbSet<StringHolder> strings { get; set; }
    }
}