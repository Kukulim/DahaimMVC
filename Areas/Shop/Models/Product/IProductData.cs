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
        Product Get(int id);
        void Add(Product product);
        void Delete(Product product);
        void Edit(Product product);
    }
}
