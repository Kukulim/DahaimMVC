using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DahaimMVC.Models
{
    public interface IUserData
    {
        IEnumerable<User> GetAll();
        User Get(int id);
        void Add(User restaurant);
        void Edit(User restaurant);
        void Delete(User restaurant);
    }
}
