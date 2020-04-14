using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DahaimMVC.Areas.Shop.Models
{
    public class SqlAuthorData : IAuthorData
    {
        private readonly StoreDbContext storeDbContex;

        public SqlAuthorData(StoreDbContext storeDbContex)
        {
            this.storeDbContex = storeDbContex;
        }
        IEnumerable<Author> IAuthorData.GetAll()
        {
            return storeDbContex.Authors;
        }
    }
}