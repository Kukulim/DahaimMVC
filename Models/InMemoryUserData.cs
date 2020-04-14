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
                new User { UserName = "muser", UserPassword = "mpass1", Name = "Lukasz", Subname = "Testowy", Email ="test@gmail.com", PhoneNumber ="123123123", LanguageLvl= LanguageLvlEmun.A0},
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
                userEdit.Name = user.Name;
                userEdit.Subname = user.Subname;
                userEdit.PhoneNumber = user.PhoneNumber;
                userEdit.LanguageLvl = user.LanguageLvl;
                userEdit.Email = user.Email;
            }
        }

        public void EditByUser(User user)
        {
            {
                User userEdit = this.Get(user.UserId);
                if (userEdit != null)
                {
                    userEdit.UserName = user.UserName;
                    userEdit.Name = user.Name;
                    userEdit.Subname = user.Subname;
                    userEdit.PhoneNumber = user.PhoneNumber;
                    userEdit.Email = user.Email;
                }
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

        public IEnumerable<User> GetAll(string sortOrder, string searchString)
        {
            var students = from s in users
                           select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                students = students.Where(s => s.Name.Contains(searchString)
                                       || s.Subname.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "name_desc":
                    students = students.OrderByDescending(s => s.Subname);
                    break;
                case "lagnuageLvl_desc":
                    students = students.OrderByDescending(s => s.LanguageLvl);
                    break;
                case "lagnuageLvl":
                    students = students.OrderBy(s => s.LanguageLvl);
                    break;

                default:
                    students = students.OrderBy(s => s.Subname);
                    break;
            }
            return students;
        }

        public User GetLogin(User user)
        {
            return users.Where(x => x.UserName == user.UserName && x.UserPassword == user.UserPassword).FirstOrDefault();
        }

        public User GetUserByName(User user)
        {
            return users.Where(x => x.UserName == user.UserName).FirstOrDefault();
        }
    }
}