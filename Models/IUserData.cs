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
        void Add(User user);
        void Edit(User user);
        void EditByUser(User user);
        void Delete(User user);
        User GetLogin(User user);
        User GetUserByName(User user);
    }
}
