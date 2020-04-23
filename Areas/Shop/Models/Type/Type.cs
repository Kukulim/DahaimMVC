using System.Collections.Generic;
using System.ComponentModel;

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