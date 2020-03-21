using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DahaimMVC.Areas.Shop.Models
{
    public interface ITypeData
    {
        IEnumerable<Type> GetAll();
        Type Get(int id);
        void Add(Type type);
        void Delete(Type type);
    }
}