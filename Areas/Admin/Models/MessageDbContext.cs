using DahaimMVC.Models;
using System.Data.Entity;

namespace DahaimMVC.Areas.Admin.Models
{
    public class MessageDbContext : DbContext
    {
        public MessageDbContext()
            : base("name=DahaimDB")
        {
        }

        public virtual DbSet<Message> Messages { get; set; }
    }
}