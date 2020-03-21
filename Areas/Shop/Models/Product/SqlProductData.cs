using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DahaimMVC.Areas.Shop.Models
{
    public class SqlProductData : IProductData
    {
        private readonly StoreDbContext storeDbContext;

        public SqlProductData(StoreDbContext storeDbContext)
        {
            this.storeDbContext = storeDbContext;
        }
        public void Add(Product product)
        {
            storeDbContext.Products.Add(product);
            storeDbContext.SaveChanges();
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public Type Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAll()
        {
            return storeDbContext.Products;
        }
    }
}