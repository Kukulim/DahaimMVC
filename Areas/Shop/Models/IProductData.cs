using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DahaimMVC.Areas.Shop.Models
{
    public interface IProductData
    {
        IEnumerable<Product> GetAll();
        Type Get(int id);
        void Add(Product product);
        void Delete(Product product);
    }
}
