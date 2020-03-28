using DahaimMVC.Areas.Shop.Models.OrdersModels;
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
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        public System.Data.Entity.DbSet<DahaimMVC.Areas.Shop.ViewModels.ShoppingCartViewModel> ShoppingCartViewModels { get; set; }
    }
}