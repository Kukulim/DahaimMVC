using System.Collections.Generic;

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