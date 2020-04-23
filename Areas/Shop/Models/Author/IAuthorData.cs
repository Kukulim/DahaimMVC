using System.Collections.Generic;

namespace DahaimMVC.Areas.Shop.Models
{
    public interface IAuthorData
    {
        IEnumerable<Author> GetAll();
    }
}