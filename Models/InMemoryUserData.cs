using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DahaimMVC.Models
{
    public class InMemoryUserData : IUserData
    {
        List<User> users;
        public InMemoryUserData()
        {
            users = new List<User>() {
                new User { UserName = "muser", UserPassword = "mpass" },
                new User { UserName = "muser1", UserPassword = "mpass2" }
            };
        }
        public void Add(User user)
        {
            users.Add(user);
            user.UserId = users.Max( r => r.UserId ) + 1;
        }

        public void Delete(User user)
        {
            users.RemoveAll( r => r.UserId == user.UserId );
        }

        public void Edit(User user)
        {
            User userEdit = this.Get(user.UserId);
            if (userEdit != null)
            {
                userEdit.UserName = user.UserName;
                userEdit.UserPassword = user.UserPassword;
            }
        }

        public User Get(int id)
        {
            return users.FirstOrDefault(e => e.UserId == id);
        }

        public IEnumerable<User> GetAll()
        {
            return users.OrderBy(r => r.UserName);
        }
        public User GetLogin(User user)
        {
            return user;
        }
    }
}