using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DahaimMVC.Models.Context
{
    public class DahaimAppContext: DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<UserModel> Users { get; set; }
    }
}