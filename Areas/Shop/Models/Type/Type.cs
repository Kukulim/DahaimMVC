using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace DahaimMVC.Areas.Shop.Models
{
    public class Type
    {
        public int TypeId { get; set; }
        [DisplayName("Typ")]
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Product> Products { get; set; }
    }
}