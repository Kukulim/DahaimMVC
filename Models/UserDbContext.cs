namespace DahaimMVC.Models
{
    using System.Data.Entity;

    public partial class UserDbContext : DbContext
    {
        public UserDbContext()
            : base("name=DahaimDB")
        {
        }

        public virtual DbSet<User> User { get; set; }
    }
}