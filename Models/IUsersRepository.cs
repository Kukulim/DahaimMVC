using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DahaimMVC.Models
{
    public interface IUsersRepository
    {
        void AddUserModel(UserModel userModel);
    }
}