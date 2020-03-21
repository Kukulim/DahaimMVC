using System;
using System.Collections.Generic;
using System.Data.Entity;
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
            var prodEdit = storeDbContext.Products.Find(product.ProductId);
            storeDbContext.Products.Remove(prodEdit);
            storeDbContext.SaveChanges();
        }

        public void Edit(Product product)
        {
            var prodEdit = storeDbContext.Products.Find(product.ProductId);
            if (prodEdit != null)
            {
                prodEdit.AuthorId = product.AuthorId;
                prodEdit.TypeId = product.TypeId;
                prodEdit.Title = product.Title;
                prodEdit.Price = product.Price;
                prodEdit.AlbumArtUrl = product.AlbumArtUrl;
                storeDbContext.SaveChanges();
            }
        }

        public Product Get(int id)
        {
            return storeDbContext.Products.Find(id);
        }

        public IEnumerable<Product> GetAll()
        {
            return storeDbContext.Products.Include( a => a.Type ).Include( a => a.Author );
        }
    }
}