using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DahaimMVC.Areas.Shop.Models
{
    public class StoreDbContext : DbContext
    {
        public StoreDbContext()
            : base("name=DahaimDB")
        {
        }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Type> Types { get; set; }

        public System.Data.Entity.DbSet<DahaimMVC.Areas.Shop.Models.Author> Authors { get; set; }
    }
}