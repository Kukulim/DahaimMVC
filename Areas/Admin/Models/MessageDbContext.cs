using DahaimMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

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
