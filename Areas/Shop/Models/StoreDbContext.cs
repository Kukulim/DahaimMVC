using DahaimMVC.Areas.Shop.Models.OrdersModels;
using DahaimMVC.Areas.Shop.ViewModels;
using System.Data.Entity;

namespace DahaimMVC.Areas.Shop.Models
{
    public class StoreDbContext : DbContext
    {
        public StoreDbContext()
            : base("name=DahaimDB")
        {
            //Database.SetInitializer(new StoreDbInitializer());
        }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Type> Types { get; set; }
        public virtual DbSet<Author> Authors { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        public DbSet<ShoppingCartViewModel> ShoppingCartViewModels { get; set; }
    }
}