using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

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
            var userEdit = database.Entry(user);
            userEdit.State = EntityState.Modified;
            database.SaveChanges();
        }

        public void EditByUser(User user)
        {
            var userEdit = database.Entry(user);
            userEdit.State = EntityState.Modified;
            database.SaveChanges();
        }

        public User Get(int id)
        {
            return database.User.FirstOrDefault(r => r.UserId == id);
        }

        public IEnumerable<User> GetAll()
        {
            return database.User;
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