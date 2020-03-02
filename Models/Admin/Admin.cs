using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DahaimMVC.Models
{
    public class Admin
    {

        public Admin()
        {
            AdminName = "admin";
            AdminPassword = "admin";
        }
        [Required]
        public string AdminName { get; set; }
        [Required]
        public string AdminPassword { get; set; }
    }
}