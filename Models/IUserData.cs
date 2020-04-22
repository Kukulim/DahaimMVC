using System.Collections.Generic;

namespace DahaimMVC.Models
{
    public interface IUserData
    {
        IEnumerable<User> GetAll();

        IEnumerable<User> GetAll(string sortOrder, string searchString);

        User Get(int id);

        void Add(User user);

        void Edit(User user);

        void EditByUser(User user);

        void Delete(User user);

        User GetLogin(User user);

        User GetUserByName(User user);
    }
}