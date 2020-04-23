using System;
using System.Collections.Generic;
using System.Linq;

namespace DahaimMVC.Models
{
    public class SqlUserData : IUserData
    {
        private readonly UserDbContext database;

        public SqlUserData(UserDbContext _database)
        {
            this.database = _database;
        }

        public void Add(User user)
        {
            database.User.Add(user);
            database.SaveChanges();
        }

        public void Delete(User user)
        {
            var userEdit = database.User.Find(user.UserId);
            database.User.Remove(userEdit);
            database.SaveChanges();
        }

        public void Edit(User user)
        {
            var userEdit = database.User.Find(user.UserId);
            if (userEdit != null)
            {
                userEdit.UserName = user.UserName;
                userEdit.Name = user.Name;
                userEdit.Subname = user.Subname;
                userEdit.PhoneNumber = user.PhoneNumber;
                userEdit.LanguageLvl = user.LanguageLvl;
                userEdit.Email = user.Email;
                database.SaveChanges();
            }
        }

        public void EditByUser(User user)
        {
            var userEdit = database.User.Find(user.UserId);
            if (userEdit != null)
            {
                userEdit.UserName = user.UserName;
                userEdit.Name = user.Name;
                userEdit.Subname = user.Subname;
                userEdit.PhoneNumber = user.PhoneNumber;
                userEdit.Email = user.Email;
                database.SaveChanges();
            }
        }

        public User Get(int id)
        {
            return database.User.FirstOrDefault(r => r.UserId == id);
        }

        public IEnumerable<User> GetAll()
        {
            return database.User;
        }

        public IEnumerable<User> GetAll(string sortOrder, string searchString)
        {
            var students = from s in database.User
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
            return database.User.Where(x => x.UserName == user.UserName && x.UserPassword == user.UserPassword).FirstOrDefault();
        }

        public User GetUserByName(User user)
        {
            return database.User.Where(x => x.UserName == user.UserName).FirstOrDefault();
        }
    }
}