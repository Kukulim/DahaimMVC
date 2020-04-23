using System;
using System.Collections.Generic;
using System.Linq;

namespace DahaimMVC.Areas.Shop.Models
{
    public class SqlTypeData : ITypeData
    {
        private readonly StoreDbContext storeDbContext;

        public SqlTypeData(StoreDbContext storeDbContext)
        {
            this.storeDbContext = storeDbContext;
        }

        public void Add(Type type)
        {
            storeDbContext.Types.Add(type);
            storeDbContext.SaveChanges();
        }

        public void Delete(Type type)
        {
            throw new NotImplementedException();
        }

        public Type Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Type> GetAll()
        {
            return storeDbContext.Types;
        }

        public Type GetType(string type)
        {
            return storeDbContext.Types.Include("Products").Single(g => g.Name == type);
        }
    }
}