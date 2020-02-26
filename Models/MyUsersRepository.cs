using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DahaimMVC.Models
{
    public class MyUsersRepository : IUsersRepository
    {
        private List<UserModel> _userModelList;

        public MyUsersRepository()
        {
            _userModelList = new List<UserModel>() {
                new UserModel(){ Login = "user", Password = "pass" },
                new UserModel(){ Login = "user1", Password = "pass1" }
            };
        }
        public void AddUserModel(UserModel userModel)
        {
            userModel.Id = _userModelList.Max(e => e.Id) + 1;
            _userModelList.Add(userModel);
        }
    }
}