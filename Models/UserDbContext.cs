namespace DahaimMVC.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class UserDbContext : DbContext
    {
        public UserDbContext()
            : base("name=DahaimDB")
        {
        }

        public virtual DbSet<User> User { get; set; }
    }
}
