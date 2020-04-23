using System.Collections.Generic;

namespace DahaimMVC.Areas.Shop.Models
{
    public interface ITypeData
    {
        IEnumerable<Type> GetAll();

        Type GetType(string type);

        Type Get(int id);

        void Add(Type type);

        void Delete(Type type);
    }
}