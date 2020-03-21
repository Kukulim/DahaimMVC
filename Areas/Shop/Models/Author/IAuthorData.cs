using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DahaimMVC.Areas.Shop.Models
{
    public interface IAuthorData
    {
        IEnumerable<Author> GetAll();

    }
}
