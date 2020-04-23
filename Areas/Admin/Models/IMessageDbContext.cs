using DahaimMVC.Models;
using System.Data.Entity;

namespace DahaimMVC.Areas.Admin.Models
{
    public interface IMessageDbContext
    {
        DbSet<Message> Messages { get; set; }
    }
}