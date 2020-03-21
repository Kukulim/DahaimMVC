using System.Data.Entity;

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
        public virtual DbSet<Author> Authors { get; set; }
    }
}