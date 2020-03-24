using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace DahaimMVC.Areas.Shop.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        [DisplayName("Autor")]
        public string AuthorName { get; set; }

    }
}