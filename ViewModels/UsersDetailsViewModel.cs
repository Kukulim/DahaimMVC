using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DahaimMVC.Models;

namespace DahaimMVC.ViewModels
{
    public class UsersDetailsViewModel
    {
        public Person Person { get; set; }
        public UserModel UserModel { get; set; }
    }
}