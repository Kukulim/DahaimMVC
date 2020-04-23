using System.Collections.Generic;

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