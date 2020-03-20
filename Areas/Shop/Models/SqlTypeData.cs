﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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
            throw new NotImplementedException();
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
    }
}